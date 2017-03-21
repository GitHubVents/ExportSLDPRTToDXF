namespace ExportSLDPRTToDXF.Models.GUI
{
    internal class ComboboxItem
    {
        public string Text { get; set; }
        public int Id { get; set; }

        public ComboboxItem(string text, int id)
        {
            Text = text;
            Id = id;
        }
        public override string ToString( )
        {
            return Text;
        }
    }
}
