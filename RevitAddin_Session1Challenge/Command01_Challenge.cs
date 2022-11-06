#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

#endregion

namespace RevitAddin_Session1Challenge
{
    [Transaction(TransactionMode.Manual)]
    public class Command01_Challenge : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;


            try
            {
                Transaction transaction = new Transaction(doc);
                transaction.Start("Create text notes");

                XYZ my3Point = new XYZ(0, 3, 0);
                XYZ my5Point = new XYZ(8, 0, 0);
                XYZ my35Point = new XYZ(16, 0, 0);
                XYZ myPoint = new XYZ(28, 0, 0);
                XYZ newPoint = myPoint;
                XYZ new3Point = my3Point;
                XYZ new5Point = my5Point;
                XYZ new35Point = my35Point;
               
                FilteredElementCollector collector = new FilteredElementCollector(doc);
                collector.OfClass(typeof(TextNoteType));

                for (int i = 0; i < 100; i++)
                {

                    if (i % 3 == 0)
                    {
                        new3Point = new3Point.Add(my3Point);
                        TextNote textNote = TextNote.Create(doc, doc.ActiveView.Id, new3Point, i.ToString() + "-" + "FIZZ" + "\n", collector.FirstElementId());
                    }


                    if (i % 5 == 0)
                    {
                        new5Point = new3Point.Add(my5Point);
                        TextNote textNote = TextNote.Create(doc, doc.ActiveView.Id, new5Point, i.ToString() + "-" + "BUZZ" + "\n", collector.FirstElementId());                     

                    }

                    if (i % 3 == 0 && i % 5 == 0 )
                    {
                        new35Point = new3Point.Add(my35Point);
                        TextNote textNote = TextNote.Create(doc, doc.ActiveView.Id, new35Point, i.ToString() + "-" + "FIZZBUZZ" + "\n", collector.FirstElementId());
                    }


                    if (i % 3 != 0 && i % 5 != 0)
                    {
                        newPoint = new3Point.Add(myPoint);
                        TextNote textNote = TextNote.Create(doc, doc.ActiveView.Id, newPoint, i.ToString() + "\n", collector.FirstElementId());
                    }

                }


                transaction.Commit();

                return Result.Succeeded;

            }

            catch (Exception e)

            {

              string Message = e.Message;

                return Result.Failed;   
            }  
        }
    }
}
