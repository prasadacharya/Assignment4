using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4.Models;
using Assignment4.APIHandlerManager;
using Newtonsoft.Json;


namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult States()
        {
            APIHandler webHandler = new APIHandler();
            States states = webHandler.GetStates();

            return View (states);
        }
        public IActionResult Categories()
        {
            APIHandler webHandler = new APIHandler();
            Categories categories = webHandler.GetCategories();
            
            return View(categories); 
        }
        public IActionResult Reports()
        {
            APIHandler webHandler = new APIHandler();
            Reports reports = webHandler.GetReports();
            return View(reports);
        }
        public IActionResult About()
        {
            return View();
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
