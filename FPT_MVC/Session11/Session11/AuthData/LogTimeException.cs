using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace Session11.AuthData
{
    public class LogTimeException : Attribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            string messsage = context.RouteData.Values["controller"]
                + "&" + context.RouteData.Values["action"]
                + @" = OnResultExecuting" + DateTime.Now.ToString("F") + Environment.NewLine;
            Log(messsage);

        }

        private void Log(string message)
        {
            string path = Path.GetFullPath(@"D:/Profile/CSharp/CShaprt/FPT_MVC/Session11/Session11/Content/Data.txt");
            File.AppendAllText(path, message);
        }
    }
}
