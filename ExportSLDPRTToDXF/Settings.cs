using System;
using System.Linq;
using EPDM.Interop.epdm;
using System.Windows.Forms; 
namespace ExportSLDPRTToDXF
{

    public partial class Settings : Form
    {
        string dxfPath;
        SolidWorksPdmAdapter PDMAdapter = new SolidWorksPdmAdapter();


        public Settings( )
        {
            InitializeComponent( );

            try
            {
                VaultsComboBox.Items.Clear( );
                BOMcomboBox.Items.Clear( );


                var vaultViews = PDMAdapter.GetVaultViews( );

                foreach (EdmViewInfo View in vaultViews)
                {
                    VaultsComboBox.Items.Add(View.mbsVaultName);
                }
                if (VaultsComboBox.Items.Count > 0)
                {
                    VaultsComboBox.Text = (string)VaultsComboBox.Items[0];
                }
              ConnectionStrToDBTextBox.Text =  Properties.Settings.Default.DataBaseConnectionString;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close( );
        }

        private void FolderDXF_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog( ))
            {
                DialogResult result = fbd.ShowDialog( );

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dxfPath = fbd.SelectedPath;
                    DXFPath_txt.Text = dxfPath;
                }
            }
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.VaultName = VaultsComboBox.SelectedItem.ToString();
            //Properties.Settings.Default.dxfPath = dxfPath;
            //Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //VaultsComboBox.ValueMember
        }
        EdmBomLayout[] edmBomLayouts;
        private void VaultsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PDMAdapter.AuthoLogin( VaultsComboBox.SelectedItem.ToString());
            edmBomLayouts = PDMAdapter.GetBoom(VaultsComboBox.SelectedItem.ToString());

            foreach (var item in edmBomLayouts)
            { 
                BOMcomboBox.Items.Add(new ComboboxItem(item.mbsLayoutName,item.mlLayoutID));
            }
            if (BOMcomboBox.Items.Count > 0)
            {
                BOMcomboBox.Text = BOMcomboBox.Items[0].ToString();
            }

        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Id { get; set; }

            public ComboboxItem(string text, int id)
            {
                Text = text;
                Id = id;
            }
            public override string ToString( )
            {
                return Text;
            }
        }
    }
}
