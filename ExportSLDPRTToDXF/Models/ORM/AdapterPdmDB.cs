using Patterns;
using System.Collections.Generic;

namespace ExportSLDPRTToDXF.Models.ORM
{
    public class AdapterPdmDB : Singeton <AdapterPdmDB>
    {
        SWPlusDataContext DataContext { get { return new SWPlusDataContext( ); } }

        protected AdapterPdmDB( ): base()
        {

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
            decimal workpieceX,
            decimal workpieceY,
            int bend,
            decimal thickness,
            int version,
            int paintX,
             int paintY,
             int paintZ,
            int IdPdm,
            decimal surfaceArea,
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
