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
                IList<int> div3List = new List<int>();
                for (int i = 0; i < 100; i++)
                {
                    if (i % 3 == 0)   
                    {
                        div3List.Add(i);
                      
                    }
                                      
                }

                    TaskDialog.Show("list of numbers divisible by 3", "List contains : " + Environment.NewLine +
                        String.Join(Environment.NewLine, div3List));

                
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
