using System;
using EPDM.Interop.epdm;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExportSLDPRTToDXF.Models.GUI;

namespace ExportSLDPRTToDXF
{

    public partial class SettingsForm : Form
    {

        #region Properties
        /// <summary>
        /// Path where to save dxf files
        /// </summary>
        private string DxfPath { get; set; }
 

        /// <summary>
        /// Component for build connection string to data base
        /// </summary>
        private  SqlConnectionStringBuilder SqlConnectionStringBuilder { get; set; }

        /// <summary>
        /// Bom Layouts array
        /// </summary>
        EdmBomLayout[] edmBomLayouts { get; set; }
        #endregion

        public SettingsForm( )
        {
            InitializeComponent( );

            SqlConnectionStringBuilder = new SqlConnectionStringBuilder(); 

            try
            {
               
                VaultsComboBox.Items.Clear( );
                BOMcomboBox.Items.Clear( );

                var vaultViews =  SolidWorksPdmAdapter.Instance.GetVaultViews( );

                foreach (EdmViewInfo View in vaultViews)
                {
                    VaultsComboBox.Items.Add(View.mbsVaultName);
                }
                if (VaultsComboBox.Items.Count > 0)
                {
                    VaultsComboBox.Text = (string)VaultsComboBox.Items[0];
                }

                LoadSettings( );
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString( ));
            }

        }


        /// <summary>
        /// The show dialog for choose folder where save dxf files 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderDXF_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog( ))
            {
                DialogResult result = fbd.ShowDialog( );

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                     //DxfPath = fbd.SelectedPath;
                    DXFPath_txt.Text = fbd.SelectedPath;
                }
            }
        }

      

        /// <summary>
        /// Handle selected vault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VaultsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            edmBomLayouts =  SolidWorksPdmAdapter.Instance.GetBoom(VaultsComboBox.SelectedItem.ToString( ));

            foreach (var item in edmBomLayouts)
            {
                BOMcomboBox.Items.Add(new ComboboxItem(item.mbsLayoutName, item.mlLayoutID));
            }
            if (BOMcomboBox.Items.Count > 0)
            {
                BOMcomboBox.Text = BOMcomboBox.Items[0].ToString( );
            }
        }

        /// <summary>
        /// Save all changes to settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSettings_Click(object sender, EventArgs e)
        {
            #region get settings from GUI controlls
            DataForm.settings.VaultName = VaultsComboBox.SelectedItem.ToString( );
            DataForm.settings.DataBaseName = SQLDB_textBox.Text;
            DataForm.settings.SqlServerName = SQLName_textBox.Text;
            DataForm.settings.SQLPassword = Pass_textBox.Text;
            DataForm.settings.SQLUser = Login_textBox.Text;
            DataForm.settings.DxfPath = DXFPath_txt.Text;
            DataForm.settings.BoomId = (BOMcomboBox.SelectedItem as ComboboxItem).Id;
           

            #endregion

            #region sql connection string build and save to settings <Commented out>

            SqlConnectionStringBuilder.ApplicationName = "ExportSLDPRTToDXF.Properties.Settings.DBConnectionString";
            SqlConnectionStringBuilder.DataSource = DataForm.settings.SqlServerName;
            SqlConnectionStringBuilder.InitialCatalog = DataForm.settings.DataBaseName;
            SqlConnectionStringBuilder.Password = DataForm.settings.SQLPassword;
            SqlConnectionStringBuilder.UserID = DataForm.settings.SQLUser;
            SqlConnectionStringBuilder.IntegratedSecurity = false;
            SqlConnectionStringBuilder.PersistSecurityInfo = true;

            DataForm.settings.DBConnectionString = SqlConnectionStringBuilder.ConnectionString;
            #endregion
            DataForm.settings.Save( );

            SolidWorksPdmAdapter.Instance.AuthoLogin(DataForm.settings.VaultName, true); 
            SolidWorksPdmAdapter.Instance.BoomId = DataForm.settings.BoomId;
            this.Close( );
        }

        /// <summary>
        /// Close settings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseSettings_Click(object sender, EventArgs e)
        {
            this.Close( );
        }

        /// <summary>
        /// Load settings and fill controlls 
        /// </summary>
        private void LoadSettings( )
        {
            DXFPath_txt.Text = DataForm.settings.DxfPath;
            SQLDB_textBox.Text = DataForm.settings.DataBaseName;
            SQLName_textBox.Text = DataForm.settings.SqlServerName;
            Login_textBox.Text = DataForm.settings.SQLUser;
            Pass_textBox.Text = DataForm.settings.SQLPassword;
            if (DataForm.settings.VaultName != null)
                VaultsComboBox.SelectedItem = VaultsComboBox.GetItemText(DataForm.settings.VaultName);
            if (DataForm.settings.BoomId != 0)
                BOMcomboBox.SelectedItem = BOMcomboBox.GetItemByValue(DataForm.settings.BoomId);
            
        }

    }
}
