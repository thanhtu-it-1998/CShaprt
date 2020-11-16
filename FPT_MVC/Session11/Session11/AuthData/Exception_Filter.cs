using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session11.AuthData
{
    public class Exception_Filter : Attribute, IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            string message = string.Empty;
            if(exception.InnerException != null)
            {
                message = exception.InnerException.Message;
            }
            else
            {
                message = exception.Message;
            }

            var result = new ViewResult { ViewName = "Error" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary(modelMetadata, context.ModelState);
            result.ViewData.Add("Exception", message);
            context.Result = result;
            context.ExceptionHandled = true;
        }
    }
}
