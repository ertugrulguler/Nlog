using NLog;
using NLog.Targets.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLogProject.Filters
{
    public class ExcFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
           
            
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(filterContext.Exception.Message);
           
        }
    }
}