using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learnMVC.Controllers
{
    public class Test1Controller1 : Controller
    {
        // GET: Test1Controller1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Test1Controller1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test1Controller1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test1Controller1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Test1Controller1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test1Controller1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Test1Controller1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test1Controller1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
