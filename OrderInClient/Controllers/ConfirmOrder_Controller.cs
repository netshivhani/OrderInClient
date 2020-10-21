using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderInClient.Controllers
{
    public class ConfirmOrder_Controller : Controller
    {
        // GET: ConfirmOrder_Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfirmOrder_Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfirmOrder_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfirmOrder_Controller/Create
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

        // GET: ConfirmOrder_Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfirmOrder_Controller/Edit/5
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

        // GET: ConfirmOrder_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfirmOrder_Controller/Delete/5
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
