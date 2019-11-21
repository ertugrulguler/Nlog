using NLog;
using NLogProject.DataAccessLayer;
using NLogProject.Filters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLogProject.Controllers
{
    public class HomeController : Controller
    {
        string db = null;
        public HomeController()
        {
             db = ConfigurationManager.ConnectionStrings["LogDB"].ConnectionString;
        }
        [ExcFilter]
        public ActionResult Index()
        {
            Test test = new Test();
            object a = 0;
            int blm = 100 / (int)a;
            #region Denemeler
            //var logger = LogManager.GetCurrentClassLogger();
            //logger.Log(LogLevel.Info, "Hata bilgisi mesajı");
            //logger.Log(LogLevel.Debug, "Debug");
            //logger.Log(LogLevel.Warn, "Sample Warn");
            //logger.Log(LogLevel.Trace, "Sample Trace");



            ////Error ve yukarısı için FileManager'ı kullanacak.
            //logger.Log(LogLevel.Error, new Exception("Hata1"));
            //logger.Log(LogLevel.Error, new Exception("Hata2")); 
            #endregion
            return View();
        }
    }
}