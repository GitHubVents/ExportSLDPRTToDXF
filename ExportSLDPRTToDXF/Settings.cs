using System;
using System.Linq;
using EPDM.Interop.epdm;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
namespace ExportSLDPRTToDXF
{

    public partial class SettingsForm : Form
    {
        string dxfPath;
        SolidWorksPdmAdapter PDMAdapter = new SolidWorksPdmAdapter();


        public SettingsForm( )
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


            //  DataForm.settings.DxfPath  
            DXFPath_txt.Text = DataForm.settings.DxfPath;
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

        private void SaveSettings_Click(object sender, EventArgs e)
        { 
            DataForm.settings.VaultName= VaultsComboBox.SelectedItem.ToString( );           
            DataForm.settings.DxfPath = dxfPath;
            DataForm.settings.BoomId = (BOMcomboBox.SelectedItem as ComboboxItem).Id;
            DataForm.settings.Save( );

            this.Close( );
        }

        private void ClouseSettings_Click(object sender, EventArgs e)
        {
            this.Close( );
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            

        }
    }
}
