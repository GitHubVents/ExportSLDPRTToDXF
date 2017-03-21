using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExportSLDPRTToDXF.Models.GUI
{
    internal static class  ExtensionComboBox
    {
        internal static ComboboxItem GetItemByText(this ComboBox subject, string text)
        {
            List<ComboboxItem> items = new List<ComboboxItem>( );
            foreach (var item in subject.Items)
            {
                items.Add(item as ComboboxItem);
            }

            return items.FirstOrDefault(each => each.Text == text);
        }
        internal static ComboboxItem GetItemByValue(this ComboBox subject, int value)
        {
            List<ComboboxItem> items = new List<ComboboxItem>( );
            foreach (var item in subject.Items)
            {
                items.Add(item as ComboboxItem);
            }

            return items.FirstOrDefault(each => each.Id == value);

        }
    }
}
