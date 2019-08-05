using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Storage.Models;

namespace Storage.Controllers
{
    public class HomeController : Controller
    {
        StorageContext db;
        public HomeController(StorageContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel
            {
                Items = db.Items.ToList(),
                Incomes = db.Incomes.ToList(),
                Expends = db.Expends.ToList()

            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> CreateIncome(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.incom.ItemId = db.Items.Where(i => i.Id == model.incom.ItemId.Id).FirstOrDefault();
                db.Incomes.Add(model.incom);
                await db.SaveChangesAsync();
            }
            else
            {
                ModelState.AddModelError("income.DocNumber", "error");
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> CreateExpend(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.expend.ItemId = db.Items.Where(i => i.Id == model.expend.ItemId.Id).FirstOrDefault();
                db.Expends.Add(model.expend);
                await db.SaveChangesAsync();
            }
            else
            {
                ModelState.AddModelError("expend.DocNumber", "error");
            }
            return RedirectToAction("Index");
        }
    }
}
