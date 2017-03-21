namespace ExportSLDPRTToDXF.Models
{
   public class Specification
    {

        public bool isDxf { get; set; }
        public string PartNumber { get; set; } // +
        public string Description { get; set; } // 
        public decimal WorkpieceX { get; set; }
        public decimal WorkpieceY { get; set; }
        public int Bend { get; set; }
        public decimal Thickness { get; set; }
        public string Configuration { get; set; }
        public int Version { get; set; }
        public int PaintX { get; set; }
        public int PaintY { get; set; }
        public int PaintZ { get; set; }
        public decimal SurfaceArea { get; set; }
        public string FileName { get; set; }           
        public int IDPDM { get; set; }
        public string FilePath { get; set; }
    }
}
