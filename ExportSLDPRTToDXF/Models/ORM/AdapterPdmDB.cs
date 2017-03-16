using System.Collections;
using System.Collections.Generic;

namespace ExportSLDPRTToDXF.Models.ORM
{
    public class AdapterPdmDB
    {
        PDMSolidWorksDBDataContext DataContext;

        public AdapterPdmDB( )
        {
            DataContext = new PDMSolidWorksDBDataContext( );
        }


        public IEnumerable<View_Part> Parts
        {
            get
            {
                return DataContext.View_Parts;
            }
        }

    }
}
