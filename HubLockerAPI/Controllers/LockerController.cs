using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubLockerAPI.Controllers
{
    public class LockerController : Controller
    {
        // GET: LockerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LockerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LockerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LockerController/Create
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

        // GET: LockerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LockerController/Edit/5
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

        // GET: LockerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LockerController/Delete/5
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
