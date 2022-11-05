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
            try
            {


                for (int i = 0; i < 100; i++)
                {
                    IList<int> div3List = new List<int>();
                    IList<int> div5List = new List<int>();
                    IList<int> div35List = new List<int>();
                    IList<int> notDiv35List = new List<int>();  

                    if (i % 3 == 0)
                    {
                        div3List.Add(i);
                        TaskDialog.Show("list of numbers divisible by 3", "List contains : " + Environment.NewLine +
                                                                               String.Join(Environment.NewLine, div3List));
                    }


                    else if (i % 5 == 0)
                    {
                        div5List.Add(i);
                        TaskDialog.Show("list of numbers divisible by 5", "List contains : " + Environment.NewLine +
                                                       String.Join(Environment.NewLine, div5List));

                    }

                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        div35List.Add(i);
                        TaskDialog.Show("list of numbers divisible by 3 and 5", "List contains : " + Environment.NewLine +
                                                       String.Join(Environment.NewLine, div35List));

                    }

                    else
                    {
                        TaskDialog.Show("list of numbers not divisible by 3 and 5", "List contains : " + Environment.NewLine +
                                                       String.Join(Environment.NewLine, notDiv35List));

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
