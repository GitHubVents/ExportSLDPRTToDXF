using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPDM.Interop.epdm;
using System.Windows.Forms;
using ExportSLDPRTToDXF.Models;

namespace ExportSLDPRTToDXF
{
    public partial class DataForm : Form
    {
        /// <summary>
        /// The SolidWorksPdmAdapter exemplare which the providing 
        /// interface to work with SolidWorks pdm
        /// </summary>
        SolidWorksPdmAdapter PDMAdapter = new SolidWorksPdmAdapter();

        /// <summary>
        /// The FileModelPdm exemplar which contains 
        /// the main data about file in the PDM
        /// </summary>
        FileModelPdm  FileModelPdm;


        public DataForm()
        {
            InitializeComponent();
            Search_textBox.Text = "04-AV04-4.1-XX"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_btn_Click_1(object sender, EventArgs e)
        {
            Settings settings_frm = new Settings();
            settings_frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            var Resaltlist = PDMAdapter.SearchDoc("%" + Search_textBox.Text + "%");
            SearchResultList.Items.Clear( );
            foreach (var item in Resaltlist)
            {
                
                SearchResultList.Items.Add(item);
            }
        }
         
        
        private void SearchResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileModelPdm = SearchResultList.SelectedItem as FileModelPdm;
            ConfigurationsComboBox.Items.AddRange( PDMAdapter.GetConfigigurations(FileModelPdm.Path));
        }

        private void ConfigurationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BomShow(ConfigurationsComboBox.SelectedItem.ToString());
        }

        private void BomShow(string configuration)
        {
            dataGridView1.DataSource = PDMAdapter.GetBomShell(FileModelPdm.Path, configuration);
        }

        //public void GetBOM_Click(System.Object sender, System.EventArgs e)
        //{

        //    try
        //    {
        //        IEdmVault7 vault2 = null;
        //        if (vault1 == null)
        //        {
        //            vault1 = new EdmVault5();
        //        }
        //        vault2 = (IEdmVault9)vault1;
        //        if (!vault1.IsLoggedIn)
        //        {
        //            vault1.LoginAuto(VaultsComboBox.Text, this.Handle.ToInt32());
        //        }

        //        if (aFile != null)
        //        {
        //            // Get named BOMs and their versions for the selected file
        //            EdmBomInfo[] derivedBOMs = null;
        //            aFile.GetDerivedBOMs(out derivedBOMs);

        //            int arrSize = 0;
        //            EdmBomVersion[] ppoVersions = null;
        //            int i = 0;
        //            int j = 0;
        //            int id = 0;
        //            string str = "";
        //            string verstr = "";
        //            int verArrSize = 0;
        //            arrSize = derivedBOMs.Length;

        //            while (i < arrSize)
        //            {
        //                id = derivedBOMs[i].mlBomID;
        //                bom = (IEdmBom)vault2.GetObject(EdmObjectType.EdmObject_BOM, id);
        //                str = "Named BOM: " + derivedBOMs[i].mbsBomName + Constants.vbLf + "Check-out user: " + bom.CheckOutUserID + Constants.vbLf + "Current state: " + bom.CurrentState.Name + Constants.vbLf + "Current version: " + bom.CurrentVersion + Constants.vbLf + "ID: " + bom.FileID + Constants.vbLf + "Is checked out: " + bom.IsCheckedOut;
        //                MessageBox.Show(str);
        //                bom.GetVersions(out ppoVersions);
        //                verArrSize = ppoVersions.Length;
        //                while (j < verArrSize)
        //                {
        //                    verstr = "BOM version: " + Constants.vbLf + "Type as defined in EdmBomVersionType: " + ppoVersions[j].meType + Constants.vbLf + "Version number: " + ppoVersions[j].mlVersion + Constants.vbLf + "Date: " + ppoVersions[j].moDate + Constants.vbLf + "Label: " + ppoVersions[j].mbsTag + Constants.vbLf + "Comment: " + ppoVersions[j].mbsComment;
        //                    MessageBox.Show(verstr);
        //                    j = j + 1;
        //                }
        //                i = i + 1;
        //            }

        //            // Get a BOM view with the specified layout
        //            bomMgr = (IEdmBomMgr)vault2.CreateUtility(EdmUtility.EdmUtil_BomMgr);
        //            EdmBomLayout[] ppoRetLayouts = null;
        //            EdmBomLayout ppoRetLayout = default(EdmBomLayout);
        //            bomMgr.GetBomLayouts(out ppoRetLayouts);
        //            i = 0;
        //            arrSize = ppoRetLayouts.Length;
        //            str = "";
        //            while (i < arrSize)
        //            {
        //                ppoRetLayout = ppoRetLayouts[i];
        //                str = "BOM Layout " + i + ": " + ppoRetLayout.mbsLayoutName + Constants.vbLf + "ID: " + ppoRetLayout.mlLayoutID;
        //                if (ppoRetLayout.mbsLayoutName == "BOM")
        //                {
        //                    bomView = aFile.GetComputedBOM(ppoRetLayout.mbsLayoutName, 0, "@", (int)EdmBomFlag.EdmBf_AsBuilt + (int)EdmBomFlag.EdmBf_ShowSelected);
        //                }
        //                MessageBox.Show(str);
        //                i = i + 1;
        //            }

        //            // Display BOM view row and column information
        //            object[] ppoRows = null;
        //            IEdmBomCell ppoRow = default(IEdmBomCell);
        //            bomView.GetRows(out ppoRows);
        //            i = 0;
        //            arrSize = ppoRows.Length;
        //            str = "";
        //            while (i < arrSize)
        //            {
        //                ppoRow = (IEdmBomCell)ppoRows[i];
        //                str = "BOM Row " + i + ": " + Constants.vbLf + "Item ID: " + ppoRow.GetItemID() + Constants.vbLf + "Path name: " + ppoRow.GetPathName() + Constants.vbLf + "Tree level: " + ppoRow.GetTreeLevel() + Constants.vbLf + " Is locked? " + ppoRow.IsLocked();
        //                MessageBox.Show(str);
        //                i = i + 1;
        //            }

        //            EdmBomColumn[] ppoColumns = null;
        //            bomView.GetColumns(out ppoColumns);
        //            i = 0;
        //            arrSize = ppoColumns.Length;
        //            str = "";
        //            while (i < arrSize)
        //            {
        //                str = "BOM Column " + i + ": " + Constants.vbLf + "Header: " + ppoColumns[i].mbsCaption + Constants.vbLf + "Column type as defined in EdmBomColumnType: " + ppoColumns[i].meType + Constants.vbLf + "ID: " + ppoColumns[i].mlColumnID + Constants.vbLf + "Flags: " + ppoColumns[i].mlFlags + Constants.vbLf + "Variable ID: " + ppoColumns[i].mlVariableID + Constants.vbLf + "Variable type as defined in EdmVariableType: " + ppoColumns[i].mlVariableType + Constants.vbLf + "Column width: " + ppoColumns[i].mlWidth;
        //                MessageBox.Show(str);
        //                i = i + 1;
        //            }
        //        }
        //    }
        //    catch (System.Runtime.InteropServices.COMException ex)
        //    {
        //        MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

    }
}
