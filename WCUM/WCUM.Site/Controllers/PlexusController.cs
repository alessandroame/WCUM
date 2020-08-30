using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Storage;

namespace WCUM.Site.Controllers
{
    public class PlexusController : Controller
    {
        public IActionResult List()
        {
            var data = JSONStorage.Load<Institute>("test.json");
            var res = data.Plexus;
            return View(res);
        }
    }
}
