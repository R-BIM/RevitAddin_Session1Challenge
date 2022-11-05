#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
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

                //TaskDialog.Show("test", "Hello World ! ");
                IList<int> div3List = new List<int>();
                for (int i = 0; i < 100; i++)
                {
                    if (i % 3 == 0)   
                    {
                        div3List.Add(i);
                      
                    }

                                       
                }

                foreach (var item in div3List)
                {
                    item.ToString();
                }
                
                TaskDialog.Show("Result", div3List.ToString());
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
