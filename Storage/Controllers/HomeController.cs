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
            return View(db.Items.ToList());
        }
    }
}
