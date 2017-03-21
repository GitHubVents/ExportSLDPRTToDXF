using System;
using System.Collections;
using System.Collections.Generic;

namespace ExportSLDPRTToDXF.Models.ORM
{
    public class AdapterPdmDB
    {
        SWPlusDataContext DataContext;


        public AdapterPdmDB(string connectionString )
        {
            DataContext = new SWPlusDataContext( );
        }
        public AdapterPdmDB( )
        {
            DataContext = new SWPlusDataContext( );
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
