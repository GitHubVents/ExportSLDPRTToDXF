namespace ExportSLDPRTToDXF.Models
{
    public class FileModelPdm
    {
        public int IDPdm { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public int CurrentVersion { get; set; }

        public string FolderPath { get; set; }
        public int FolderId { get; set; }



        public override string ToString( )
        {
            return FileName;
        }
    }
}
