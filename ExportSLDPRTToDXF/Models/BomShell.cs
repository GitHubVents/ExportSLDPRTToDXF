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
        /// Количество
        /// </summary>
        
        public decimal? Count { get; set; } // +
        /// <summary>
        /// Тип файла
        /// </summary>
       
        public string FileType { get; set; } // -
        /// <summary>
        /// Конфигурация
        /// </summary>
        
        public string Configuration { get; set; } // -
        /// <summary>
        /// Последняя версия
        /// </summary>
      
        public int? LastVesion { get; set; } // -
        /// <summary>
        /// Уровень
        /// </summary>
      
        public int? Level { get; set; } // -
        /// <summary>
        /// Состояние
        /// </summary>
        
        public string State { get; set; } // -
        /// <summary>
        /// Раздел
        /// </summary>
      
        public string Partition { get; set; } // +
        /// <summary>
        /// Обозначение
        /// </summary>
       
        public string PartNumber { get; set; } // +
        /// <summary>
        /// Наименование
        /// </summary>
     
        public string Description { get; set; } // +
        /// <summary>
        /// Материал
        /// </summary>
        
        public string Material { get; set; } // -
        /// <summary>
        /// Материал Цми
        /// </summary>
       
        public string MaterialCmi { get; set; } // -
        /// <summary>
        /// Толщина листа
        /// </summary>
       
        public string SheetThickness { get; set; } //-

 
        public int? IdPdm { get; set; } // -
        /// <summary>
        /// Имя файла
        /// </summary>
       
        public string FileName { get; set; }
        /// <summary>
        /// Путь к файлу
        /// </summary>
       
        public string FilePath { get; set; }
        /// <summary>
        /// Erp код
        /// </summary>
   
        public string ErpCode { get; set; } // +
        /// <summary>
        /// 
        /// </summary>
        
        public string SummMaterial { get; set; } //+
        
        public string Weight { get; set; }
  
        public string CodeMaterial { get; set; } //+
   
        public string Format { get; set; }
   
        public string Note { get; set; }
   
        public int? Position { get; set; }
        /// <summary>
        /// Количество по конфигурации
        /// </summary>
         
        public List<decimal> CountByConfiguration { get; set; }
        /// <summary>
        /// Конфигурация главной сборки
        /// </summary>
 
        public string ConfigurationMainAssembly { get; set; }
        /// <summary>
        /// Тип объекта
        /// </summary>
    
        public string TypeObject { get; set; }
       
        public string GetPathName { get; set; }
    }
}
