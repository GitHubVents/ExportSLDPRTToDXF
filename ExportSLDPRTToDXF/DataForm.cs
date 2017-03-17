using System;
using System.Windows.Forms;
using ExportSLDPRTToDXF.Models;
using ExportSLDPRTToDXF.Models.ORM;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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

       internal static Properties.Settings settings { get; private set; } = Properties.Settings.Default; 
        #endregion fields

        public DataForm()
        {
            InitializeComponent();
            Search_textBox.Text = "3535";
            Patterns.Observer.MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;

             
        }

         

        private void Settings_btn_Click(object sender, EventArgs e)
        {  
            SettingsForm settings_frm = new SettingsForm();
            settings_frm.ShowDialog();
           
        }
       
        /// <summary>
        /// Обработчик кнокп поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (ConfigurationsComboBox.Items.Count > 0)
            {
                ConfigurationsComboBox.Text = (string)ConfigurationsComboBox.Items[0];                 
            }
        }

        /// <summary>
        /// Occurs when selected eny item in the ConfigurationsComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigurationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SpecificationDataGrid.Rows.Clear( );
            SpecificationDataGrid.DataSource = null;
            FillDataGridSpecification(ConfigurationsComboBox.SelectedItem.ToString());
        }
        Specification[] specification;
        /// <summary>
        /// Fill data grid specification
        /// </summary>
        /// <param name="configuration"></param>
        private void FillDataGridSpecification(string configuration)
        {
            SpecificationDataGridClear( );
             
                specification = GetSpecification(FileModelPdm.Path, configuration);
            SpecificationDataGrid.DataSource = specification; //from viewSpec in specification
            //                                   select new
            //                                   {
            //                                       DXF = viewSpec.isDxf,
            //                                       Наименование = viewSpec.PartNumber,
            //                                       Обозначение = viewSpec.Description,
            //                                       Конфигурация = viewSpec.Configuration,
            //                                       Версия = viewSpec.Version
            //                                   };             
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

            if (bomShell != null)
            {
                IEnumerable<Specification> specifications = null;

                try
                {

                    specifications = from eachBom in bomShell
                                     join eachPart in parts on new { id = (int)eachBom.IdPdm, ver = (int)eachBom.Version, conf = eachBom.Configuration }
                                        equals new { id = (int)eachPart.IDPDM, ver = (int)eachPart.Version, conf = eachPart.ConfigurationName }
                                        into Spec_s
                                     from spec in Spec_s.DefaultIfEmpty( )
                                     select new Specification
                                     {
                                         Description = eachBom.Description,
                                         PartNumber = eachBom.PartNumber,
                                         Version = eachBom.Version,
                                         Configuration = eachBom.Configuration,
                                         IDPDM = eachBom.IdPdm,
                                          
                                         Bend = (int)(spec == null ? 0 : spec.Bend),
                                         PaintX = (int)(spec == null ? 0 : spec.PaintX),
                                         PaintY = (int)(spec == null ? 0 : spec.PaintY),
                                         PaintZ = (int)(spec == null ? 0 : spec.PaintZ),
                                         WorkpieceX = (double)(spec == null ? 0 : spec.WorkpieceX),
                                         WorkpieceY = (double)(spec == null ? 0 : spec.WorkpieceY),
                                         SurfaceArea = (double)(spec == null ? 0 : spec.SurfaceArea),
                                         isDxf = (spec == null || spec.DXF != "1") ? false : true,
                                         FileName = eachBom.FileName,
                                         FilePath = Path.Combine(eachBom.FolderPath, eachBom.FileName)
                                     };
                }

                catch (Exception ex)
                {

                     MessageBox.Show( ex.ToString());
                }
                return specifications.ToArray( );
            }
            return null;
           
        }


        #region GUI controllers clear region

        void SearchResultListClear( )
        {
            SearchResultList.Items.Clear( );
        }

      

        void SpecificationDataGridClear ()
        {
         //   if (SpecificationDataGrid.Rows.Count > 0)
                //SpecificationDataGrid.Rows.Clear( );
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

        /// <summary>
        /// Запуск построения DXF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpLoadDxfButton_Click(object sender, EventArgs e)
        {
            SolidWorksLibrary.Builders.Dxf.DxfBulder DxfBulder = SolidWorksLibrary.Builders.Dxf.DxfBulder.Instance;
           
            DxfBulder.DxfFolder = @"C:\DXF";
            DxfBulder.FinishedBuilding += DxfBulder_FinishedBuilding;
            PDMAdapter.GetEdmFile5(FileModelPdm.Path);


            if (specification != null)
            {
                foreach (var item in specification)
                {
                    if (!item.isDxf && Path.GetExtension( item.FileName).ToUpper() == ".SLDPRT")
                    {                   
                              
                        DxfBulder.Build(item.FilePath, item.IDPDM, item.Version);
                    }
                }
            } 
        }
        /// <summary>
        /// Выгрузка CutList для каждого построеного dxf
        /// </summary>
        /// <param name="dataToExport"></param>
        private void DxfBulder_FinishedBuilding(SolidWorksLibrary.Builders.Dxf.DataToExport dataToExport)
        {
            AdapterPdmDB.UpDateCutList(  dataToExport.Configuration, dataToExport.DXFByte,dataToExport.WorkpieceX,dataToExport.WorkpieceY,  dataToExport.Bend, dataToExport.Thickness, dataToExport.Version, 
                dataToExport.PaintX, dataToExport.PaintY, dataToExport.PaintZ, dataToExport.IdPdm, dataToExport.SurfaceArea,dataToExport.MaterialID);
        }
        /// <summary>
        /// Обработка системных сообщений
        /// </summary>
        /// <param name="massage"></param>
        private void Instance_ReceivedMessage(Patterns.Observer.MessageEventArgs massage)
        {
            Logger.ToLog($"Time:{massage.time} Message: {massage.Message}");
            if (massage.Type == Patterns.Observer.MessageType.Error)
                MessageBox.Show(massage.Message);
        }
         
      
    }
}
