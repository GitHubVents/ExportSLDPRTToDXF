namespace ExportSLDPRTToDXF.Models
{
   public class Specification
    {
        // from bom [t]
       
        public string FileName { get; set; }

        // from Nomenclature [t] 
        //[DataMember]
        //public string Nomenclature { get; set; }
        //[DataMember]
        //public int NomenclatureGroupID { get; set; }
       
        public string ERPCode { get; set; }
       
        public string IDPDM { get; set; }
        //[DataMember]
        //public bool Deleted { get; set; }

        // from part [t]

        //[DataMember]
        //public int MaterialID { get; set; } //change on material name

       
        public string WorkpieceX { get; set; }

       

        public string WorkpieceY { get; set; }
       
        public string Bend { get; set; }
       
        public string Thickness { get; set; }
       
        public string Configuration { get; set; }
       
        public string Version { get; set; }
       
        public string PaintX { get; set; }
       
        public string PaintY { get; set; }
       
        public string PaintZ { get; set; }

       
        public string SurfaceArea { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
       
        public int Count { get; set; } // +


       
        public string Partition { get; set; } // +
        /// <summary>
        /// Обозначение
        /// </summary>
       
        public string PartNumber { get; set; } // +
        /// <summary>
        /// Наименование
        /// </summary>
       
        public string Description { get; set; } // +     


       
        public string SummMaterial { get; set; }
       
        public string Weight { get; set; }

       
        public string CodeMaterial { get; set; }

        /// <summary>
        /// Is entry have dxf data.
        /// </summary>
       
        public string isDxf { get; set; }
        /// <summary>
        /// Item type {sldprt or sldasm}
        /// </summary>
       
        public string Type { get; set; }

       
        public int Level { get; set; }
    }
}
