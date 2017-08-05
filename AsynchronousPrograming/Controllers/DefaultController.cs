using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsynchronousPrograming.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            ContentManagement service = new ContentManagement();
            service.GetContent();
            service.GetNumber();
            watch.Stop();
            ViewBag.Milliseconds = watch.ElapsedMilliseconds;
            return View();
        }

        public async Task<ActionResult> IndexAsync()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            ContentManagement service = new ContentManagement();
            var contentTask = service.GetContentAsync();
            var numberTask = service.GetNumbreAsync();
            await contentTask;
            await numberTask;
            watch.Stop();
            ViewBag.Milliseconds = watch.ElapsedMilliseconds;
            return View();
        }
    }
}