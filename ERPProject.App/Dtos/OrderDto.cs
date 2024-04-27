using ERPProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPProject.App.Dtos
{
    public class OrderListingDto
    {

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerMobile { get; set; }
        public string OrderBy { get; set; }
        public double TotalAmount { get; set; }
        public ESaleOrderStatus OrderStatus { get; set; }
    }
}
