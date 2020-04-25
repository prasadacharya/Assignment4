using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4.Models;
using Assignment4.APIHandlerManager;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Assignment4.DataAccess;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

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

        public IActionResult SurveyData(string reportName)
        {
            APIHandler webHandler = new APIHandler();
            SurveyDatas surveydatas = webHandler.GetSurveyDatas(reportName);
            ViewBag.Reports = new APIHandler().GetReports();
            return View(surveydatas);
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

        public IActionResult Chart()
        {
            APIHandler webHandler = new APIHandler();
            ViewBag.dbSuccessChart = 0;
            SurveyDatas surveydatas = null;
            
            return View("Charts", surveydatas);
        }

        private SurveyDatas GetSurveyData(string report)
        {
            throw new NotImplementedException();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /* Below method will save states to Database if count == 0 */
        public IActionResult SaveStates()
        {
            APIHandler apiHandler = new APIHandler();
            States state = apiHandler.GetStates();
            List<State> cd = state.data;
            foreach (State cd1 in cd)
            {
                if (dbContext.State.Where(c => c.id.Equals(cd1.id)).Count() == 0)
                {
                    dbContext.State.Add(cd1);
                    ViewBag.Message = "Database Updated";
                }
            }
            dbContext.SaveChanges();
            ViewBag.dbSuccessComp = 1;
            return View("States", state);
        }

        /* Below method will save Categories to Database if count == 0 */
        public IActionResult SaveCategories()
        {
            APIHandler apiHandler = new APIHandler();
            Categories category = apiHandler.GetCategories();
            List<Category> cd = category.data;
            foreach (Category cd1 in cd)
            {
                if (dbContext.Category.Where(c => c.id.Equals(cd1.id)).Count() == 0)
                {
                    dbContext.Category.Add(cd1);
                    ViewBag.Message = "Database Updated";
                }
            }
            dbContext.SaveChanges();
            ViewBag.dbSuccessComp = 1;
            return View("Categories", category);
        }

    }
}
