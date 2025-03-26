using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.DAL.Entities
{
    public class Shop
    {
        public int Id { get; set; } 
        public string ShopName { get; set; }

      

        public int? PlaceId { get; set; }

        public PlaceOfInterest Place { get; set; }


     
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
