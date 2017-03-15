using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportSLDPRTToDXF.Models
{
  public  class FileModelPdm
    { 
        public string FileName { get; set; }         
        public int FolderId { get; set; }         
        public int IDPdm { get; set; }         
        public string Path { get; set; }         
        public string FolderPath { get; set; } 
        public int CurrentVersion { get; set; }
    }
}
