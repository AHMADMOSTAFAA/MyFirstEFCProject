using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.BL
{
    public class UserUIService
    {
        DBContext dbContext=new DBContext();
        public List<object> ShowReservations(int UID)
        {
            return dbContext.userPlaceOfIntrests
                .Where(up => up.UserId == UID)
                .Select(up => new
                {
                    PlaceId = up.PlaceId,  // Include PlaceId for internal use
                    PlaceName = up.Place.PName,
                    ReservationDate = up.ReservationDate,
                    EndDate = up.EndDate,
                    Price = up.Price
                })
                .ToList<object>();
        }

        public List<object> ShowShop(int pID)
        {
            var result = dbContext.shops
                .Where(s => s.PlaceId == pID)
                .SelectMany(s => s.Products, (s, p) => new
                {
                    ProductId = p.Id,
                    ShopName = s.ShopName,
                    ProductName = p.ProdName,  
                    ProductPrice = p.Price,       
                    PlaceId = s.PlaceId
                })
                .ToList();

            return result.Cast<object>().ToList(); 
        }
        public List<object> ShowUserProducts(int UID)
        {
            var result = dbContext.UserProducts
                .Where(up => up.UserId == UID)
                .Select(up => new
                {
                    ProductId = up.ProductId,
                    ProductName = up.Product.ProdName,
                    ProductPrice = up.Product.Price,
                    Quantity = up.Quantity
                })
                .ToList();

            return result.Cast<object>().ToList();
        }
    }
}
