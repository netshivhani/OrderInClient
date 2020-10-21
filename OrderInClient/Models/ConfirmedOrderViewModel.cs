using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderInClient.Models
{
    public class ConfirmedOrderViewModel
    {
        public int Order_Id { get; set; }
        public string RestaurantName { get; set; }
        public string Suburb { get; set; }
        public string Price { get; set; }

    }
}
