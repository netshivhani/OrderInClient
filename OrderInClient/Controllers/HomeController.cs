using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderInClient.Models;
using Syncfusion.EJ2.Navigations;

//using EJ2CoreSampleBrowser.Models;

namespace OrderInClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public ActionResult Details(SearchRequest searchRequest)
        {
            string[] searchText = searchRequest.SearchText.ToString().Split("in");
            var menuItem = searchText[0].ToString().Trim();
            var city = searchText[1].ToString().Trim();

            List<OrderinClientModel> orderinClientModel = null;
            using (var client = new HttpClient())
            {
                var orderInViewModel = new OrderInViewModel
                {
                    MenuItem = menuItem,
                    City = city,
                };

                client.BaseAddress = new Uri("https://localhost:44367/api/OrderIn/");
                //HTTP GET
                var responseTask = client.PostAsJsonAsync("GetMenuItem",orderInViewModel);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<List<OrderinClientModel>>();
                    readTask.Wait();

                    orderinClientModel = readTask.Result;

                }
            }
            return PartialView("_Result",orderinClientModel);
        }

        //public partial class AutoCompleteController : Controller
        //{
        //    public IActionResult CustomFiltering()
        //    {
        //        ViewBag.data = new OrderInViewModel().City();
        //        return View();
        //    }
        //}
    


    public IActionResult Privacy()
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
