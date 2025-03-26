using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProdName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public List<UserProduct> UserProducts { get; set; } = new List<UserProduct>();//new
    }
}
