using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public int UserId { get; set; }
    }
}
