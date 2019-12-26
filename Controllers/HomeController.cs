using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using locationfinder.Models;

namespace locationfinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LocationLists model = new LocationLists();
            var locations = new List<Locations>()
            {
                new Locations(1, "IBM DLF1","IBM DLF1, Kolkata", 22.581431, 88.450462),
                new Locations(2, "IBM BCS","IBM BCS, Kolkata", 22.5718, 88.4346),
                new Locations(3, "Bengaluru","Bengaluru, Karnataka", 12.972442, 77.580643)
            };
            model.LocationList = locations;
            return View(model);
        }
    }
}
