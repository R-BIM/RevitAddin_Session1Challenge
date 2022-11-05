#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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

                TaskDialog.Show("test", "Hello World ! ");


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
