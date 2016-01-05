using BusinessLayer.Interfaces;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        private ITestServices service;

        public TestController(ITestServices service)
        {
            this.service = service;
        }

        // GET: Test
        public ActionResult Index()
        {
            var model = new TestModel();
            model.TestString = service.TestMethod();

            return View(model);
        }
    }
}