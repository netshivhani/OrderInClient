using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderInClient.Models;

namespace OrderInClient.Models
{
    public class OrderinClientModel
    {
        public string RestaurantName { get; set; }
        public string Suburb { get; set; }
        public int Rank { get; set; }
        public string MenuItem { get; set; }
        public decimal Price { get; set; }
    }
}
