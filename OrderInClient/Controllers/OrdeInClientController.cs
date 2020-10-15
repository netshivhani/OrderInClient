using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderInClient.Models;

namespace OrderInClient.Controllers
{
    public class OrdeInClientController : Controller
    {
  

        // GET: OrdeInClientController/Details/5
        [HttpGet]
        public ActionResult Details(string menuName, string city)
        {
            OrderinClientModel orderinClientModel;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367//api/OrderIn/");
                //HTTP GET
                var responseTask = client.GetAsync($"GetMenuItem/{menuName}&{city}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<OrderinClientModel>();
                    readTask.Wait();

                    orderinClientModel = readTask.Result;
                  
                }
            }
            return View();
        }



    }
}
