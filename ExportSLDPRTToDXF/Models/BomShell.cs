using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExportSLDPRTToDXF.Models
{
    /// <summary>
    ///  Bill of Materials (BOM) view.
    /// </summary>
  
    public class BomShell
    {
        /// <summary>
        /// Конфигурация
        /// </summary>
        
        public string Configuration { get; set; } 
        /// <summary>
        /// Последняя версия
        /// </summary>
      
        public int Version { get; set; }       
     
        /// <summary>
        /// Обозначение
        /// </summary>
       
        public string PartNumber { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
     
        public string Description { get; set; } 
      
        public int IdPdm { get; set; }


        public string FileName { get; set; }
        public string FolderPath { get; set; }
    
      public string ObjectType { get; set; }
        public string Partition { get; set; }

    }
}
