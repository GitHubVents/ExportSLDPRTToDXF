using System;
using System.Windows.Forms;
using ExportSLDPRTToDXF.Models;
using ExportSLDPRTToDXF.Models.ORM;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using EPDM.Interop.EPDMResultCode;

namespace ExportSLDPRTToDXF
{
    public partial class DataForm : Form
    {
        #region fields
      

        /// <summary>
        /// The AdapterPdmDB exemplare which the providing 
        /// interface to work with PDM SolidWorks data base
        /// </summary>
        AdapterPdmDB AdapterPdmDB;
        /// <summary>
        /// The FileModelPdm exemplar which contains 
        /// the main data about file in the PDM
        /// </summary>
        FileModelPdm  FileModelPdm;

       internal static Properties.Settings settings { get; private set; } = Properties.Settings.Default; 
        #endregion fields

        public DataForm()
        {
           
               AdapterPdmDB = new AdapterPdmDB( settings.DBConnectionString );

            InitializeComponent();
            Search_textBox.Text = "3535";
            Patterns.Observer.MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;
            SolidWorksPdmAdapter.Instance.BoomId = DataForm.settings.BoomId;
            PdmLogin( );
        }         

        public   void PdmLogin ()
        {
            try
            {
                if (!String.IsNullOrEmpty(settings.VaultName))

                {
                    SolidWorksPdmAdapter.Instance.AuthoLogin(settings.VaultName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не верное имя PDM вида: " + settings.VaultName + "\n" + ex.Message);
            }
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
            try
            {
                var Resaltlist =  SolidWorksPdmAdapter.Instance.SearchDoc("%" + Search_textBox.Text + "%");
                foreach (var item in Resaltlist)
                {
                    SearchResultList.Items.Add(item);
                }

            }
            catch (COMException ex)
            {
                MessageBox.Show("Error: " + (EdmResultErrorCodes_e)ex.ErrorCode);
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
            ConfigurationsComboBox.Items.AddRange(  SolidWorksPdmAdapter.Instance.GetConfigigurations(FileModelPdm.Path));

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
            SpecificationDataGrid.DataSource = specification; //  from viewSpec in specification
            //select new
            //{
            //    DXF = viewSpec.isDxf,
            //    Наименование = viewSpec.PartNumber,
            //    Обозначение = viewSpec.Description,
            //    Конфигурация = viewSpec.Configuration,
            //    Версия = viewSpec.Version
            //};
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

                var bomShell =  SolidWorksPdmAdapter.Instance.GetBomShell(filePath, configuration);
            if (bomShell != null)
            {
                IEnumerable<Specification> specifications = null;
                try
                { 
                    specifications = from eachBom in bomShell
                                     join eachPart in parts on new { id =  eachBom.IdPdm, ver =  eachBom.Version, conf = eachBom.Configuration }
                                        equals new { id =  (int)eachPart.IDPDM, ver =  eachPart.Version, conf = eachPart.ConfigurationName }
                                        into Spec_s
                                     from spec in Spec_s.DefaultIfEmpty( )
                                     select new Specification
                                     {
                                         Description = eachBom.Description,
                                         PartNumber = eachBom.PartNumber,
                                         Version = eachBom.Version,
                                         Configuration = eachBom.Configuration,
                                         IDPDM = eachBom.IdPdm,

                                         Bend =  (spec == null ? 0 : spec.Bend),
                                         PaintX =  (spec == null ? 0 : spec.PaintX),
                                         PaintY =  (spec == null ? 0 : spec.PaintY),
                                         PaintZ =  (spec == null ? 0 : spec.PaintZ),
                                         WorkpieceX = (spec == null ? 0 : spec.WorkpieceX),
                                         WorkpieceY = (spec == null ? 0 : spec.WorkpieceY),
                                         SurfaceArea = (spec == null ? 0 : spec.SurfaceArea),
                                         isDxf = (spec == null || spec.DXF != "1") ? false : true,
                                         FileName = eachBom.FileName,
                                         FilePath = Path.Combine(eachBom.FolderPath, eachBom.FileName),
                                         Thickness = (spec == null ? 0 : spec.Thickness)
                                     };

                    return specifications.ToArray( );
                }
                catch (Exception ex)
                {
                     MessageBox.Show( ex.ToString());
                }
               
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

            string pathToDxf = settings.DxfPath;
            if (String.IsNullOrEmpty(pathToDxf))
            {
                MessageBox.Show("Не указан путь для выгрузки DXF");
                //003540.
            }
            else
            {
                pathToDxf = Path.Combine(settings.DxfPath, "DXF");
                DxfBulder.DxfFolder = pathToDxf;
                DxfBulder.FinishedBuilding += DxfBulder_FinishedBuilding;
                 SolidWorksPdmAdapter.Instance.GetEdmFile5(FileModelPdm.Path);
                if (specification != null)
                {
                    foreach (var item in specification)
                    {
                        if (!item.isDxf && Path.GetExtension(item.FileName).ToUpper() == ".SLDPRT")
                        {
                           
                            DxfBulder.Build(item.FilePath, item.IDPDM, item.Version);
                        }
                    }
                }
                SpecificationDataGrid.Update( );
                SpecificationDataGrid.Refresh( );
            }

        }
        /// <summary>
        /// Выгрузка CutList для каждого построеного dxf
        /// </summary>
        /// <param name="dataToExport"></param>
        private void DxfBulder_FinishedBuilding(SolidWorksLibrary.Builders.Dxf.DataToExport dataToExport)
        {
            //MessageBox.Show($"DxfBulder_FinishedBuilding: x {dataToExport.PaintX}, Y  {dataToExport.PaintY}, Z {dataToExport.PaintZ}");

            AdapterPdmDB.UpDateCutList(  dataToExport.Configuration, 
                dataToExport.DXFByte,
                dataToExport.WorkpieceX,
                dataToExport.WorkpieceY,  
                dataToExport.Bend, 
                dataToExport.Thickness, 
                dataToExport.Version, 
                dataToExport.PaintX, 
                dataToExport.PaintY,
                dataToExport.PaintZ,
                dataToExport.IdPdm, 
                dataToExport.SurfaceArea,
                dataToExport.MaterialID
                );
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

        private void Search_textBox_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(Search_textBox, "Поле поиска");
        }

        private void ConfigurationsComboBox_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(ConfigurationsComboBox, "Список конфигураций");
        }
    }
}
