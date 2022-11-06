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
                XYZ myPoint = new XYZ(0, 5, 0);
                XYZ newPoint = myPoint + new XYZ(0, 5, 0);
                FilteredElementCollector collector = new FilteredElementCollector(doc);
                collector.OfClass(typeof(TextNoteType));    
                    

                for (int i = 0; i < 100; i++)
                {

                    if (i % 3 == 0)
                    {
                        Transaction transaction = new Transaction(doc);
                        transaction.Start("Create text notes");

                        TextNote textNote = TextNote.Create(doc, doc.ActiveView.Id, myPoint, i.ToString() + "FIZZ" + "\n", collector.FirstElementId());

                     transaction.Commit();
                    }


                    else if (i % 5 == 0)
                    {


                    }

                    else if (i % 3 == 0 && i % 5 == 0)
                    {


                    }

                    else
                    {


                    }

                    //var switch_on = true;

                    //switch (switch_on)

                    //{

                    //    case
                    //    i % 3 == 0:
                    //        div3List.Add(i);
                    //        TaskDialog.Show("list of numbers divisible by 3", "List contains : " + Environment.NewLine +
                    //                                                               String.Join(Environment.NewLine, div3List));
                    //        break;


                    //        case
                    //        i % 5 == 0:
                    //        div5List.Add(i);
                    //        TaskDialog.Show("list of numbers divisible by 3", "List contains : " + Environment.NewLine +
                    //                                   String.Join(Environment.NewLine, div3List));
                    //        break;

                    //case
                    //    i % 3 == 0 && i % 5 == 0: div35List.Add(i);
                    //    TaskDialog.Show("list of numbers divisible by 3", "List contains : " + Environment.NewLine +
                    //   String.Join(Environment.NewLine, div35List));

                }

                return Result.Succeeded;

            }

            catch (Exception e)

            {

              string Msage = e.Message;

                return Result.Failed;   
            }  
        }
    }
}
