using System;
using System.Windows.Forms;
using ExportSLDPRTToDXF.Models;
using ExportSLDPRTToDXF.Models.ORM;
using System.Linq;

namespace ExportSLDPRTToDXF
{
    public partial class DataForm : Form
    {
        #region fields
        /// <summary>
        /// The SolidWorksPdmAdapter exemplare which the providing 
        /// interface to work with SolidWorks pdm
        /// </summary>
        SolidWorksPdmAdapter PDMAdapter = new SolidWorksPdmAdapter();

        /// <summary>
        /// The AdapterPdmDB exemplare which the providing 
        /// interface to work with PDM SolidWorks data base
        /// </summary>
        AdapterPdmDB AdapterPdmDB = new AdapterPdmDB();


        /// <summary>
        /// The FileModelPdm exemplar which contains 
        /// the main data about file in the PDM
        /// </summary>
        FileModelPdm  FileModelPdm;
        #endregion fields

        public DataForm()
        {
            InitializeComponent();
            Search_textBox.Text = "04-AV04-4.1-XX"; 
        }

       

        private void Settings_btn_Click_1(object sender, EventArgs e)
        {
            Settings settings_frm = new Settings();
            settings_frm.ShowDialog();
        }
       

        private void Search_btn_Click(object sender, EventArgs e)
        {
            ClearAllControllers( );
            var Resaltlist = PDMAdapter.SearchDoc("%" + Search_textBox.Text + "%");             
            foreach (var item in Resaltlist)
            {
                
                SearchResultList.Items.Add(item);
            }
        }

        /// <summary>
        /// Occurs when selected eny item in the SearchResultList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurationsComboBoxClear( );
            FileModelPdm = SearchResultList.SelectedItem as FileModelPdm;
            ConfigurationsComboBox.Items.AddRange( PDMAdapter.GetConfigigurations(FileModelPdm.Path)); 
        }

        /// <summary>
        /// Occurs when selected eny item in the ConfigurationsComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigurationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridSpecification(ConfigurationsComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Fill data grid specification
        /// </summary>
        /// <param name="configuration"></param>
        private void FillDataGridSpecification(string configuration)
        {

            SpecificationDataGrid.DataSource = GetSpecification(FileModelPdm.Path, configuration);
        }

        /// <summary>
        /// Returns specification by each parts. 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public Specification[] GetSpecification(string filePath, string configuration)
        {             
                var parts = AdapterPdmDB.Parts;
                var bomShell = PDMAdapter.GetBomShell(filePath, configuration); 

                var specifications = from eachBom in bomShell
                                     join eachPart in parts on new { id = (int)eachBom.IdPdm, ver = (int)eachBom.LastVesion, conf = eachBom.Configuration }
                                     equals new { id = (int)eachPart.IDPDM, ver = (int)eachPart.Version, conf = eachPart.ConfigurationName }
                                     into Spec_s
                                     from spec in Spec_s.DefaultIfEmpty( )
                                     select new Specification
                                     {
                                         Description = eachBom.Description,
                                         Count = (int)eachBom.Count,
                                         Weight = eachBom.Weight,
                                         Partition = eachBom.Partition,
                                         PartNumber = eachBom.PartNumber,
                                         ERPCode = eachBom.ErpCode,
                                         SummMaterial = eachBom.SummMaterial,
                                         Configuration = eachBom.Configuration,
                                         IDPDM = eachBom.IdPdm.ToString( ),
                                         CodeMaterial = eachBom.CodeMaterial,
                                         Type = eachBom.FileType,
                                         Level = (int)eachBom.Level,

                                         Version = (spec == null ? string.Empty : spec.Version.ToString( )),
                                         Bend = spec == null ? string.Empty : spec.Bend.ToString( ),
                                         PaintX = spec == null ? string.Empty : spec.PaintX.ToString( ),
                                         PaintY = spec == null ? string.Empty : spec.PaintY.ToString( ),
                                         PaintZ = spec == null ? string.Empty : spec.PaintZ.ToString( ),
                                         WorkpieceX = spec == null ? string.Empty : spec.WorkpieceX.ToString( ),
                                         WorkpieceY = spec == null ? string.Empty : spec.WorkpieceY.ToString( ),
                                         SurfaceArea = spec == null ? string.Empty : spec.SurfaceArea.ToString( ), 
                                         isDxf = spec != null && spec.DXF == "1" ? "true" : "false"    ,
                                         FileName = eachBom.FileName

                                     }; 
                return specifications.ToArray( );
            }


        #region GUI controllers clear region

        void SearchResultListClear( )
        {
            SearchResultList.Items.Clear( );
        }

      

        void SpecificationDataGridClear ()
        {
            if (SpecificationDataGrid.Rows.Count > 0)
                SpecificationDataGrid.Rows.Clear( );
        }

        void ConfigurationsComboBoxClear ()
        {
            ConfigurationsComboBox.Items.Clear( );
        }

        void ClearAllControllers ()
        {
            SearchResultListClear( );
            SpecificationDataGridClear( );
            ConfigurationsComboBoxClear( );
        }
        #endregion GUI controllers clear region
    }
}
