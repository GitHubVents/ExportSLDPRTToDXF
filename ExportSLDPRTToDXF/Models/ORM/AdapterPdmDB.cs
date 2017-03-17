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

        public void UpDateCutList(

            string configuration,
            byte[] DXFByte,
            float workpieceX,
            float workpieceY,
            int bend,
            float thickness,
            int version,
            int paintX,
             int paintY,
             int paintZ,
            int IdPdm,
            float surfaceArea,
            int? materialID = null
            )
        {

            DataContext.DXFUpDateCutList(
                                      workpieceX,
                                      workpieceY,
                                      bend,
                                      thickness,
                                      configuration,
                                      version,
                                      paintX,
                                      paintY,
                                      paintZ,
                                      IdPdm,
                                      materialID,
                                      surfaceArea,
                                      new System.Data.Linq.Binary(DXFByte)
                                      );
        }
    }
}
