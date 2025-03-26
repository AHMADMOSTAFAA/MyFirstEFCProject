using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.BL
{
    public class OwnerUI
    {
        DBContext dbContext=new DBContext();
        public List<Product> ShowProductsForOwner(int ownerId, int placeId, int shopId)
        {
            var products = dbContext.products
                .Where(p => p.ShopId == shopId &&
                            p.Shop.PlaceId == placeId &&
                            p.Shop.Place.ownerid == ownerId) // Ensure owner owns the place
                .ToList();
            return products;
        }
        public List<object> ShowReservations(int pid)
        {
            return dbContext.userPlaceOfIntrests
                .Where(up => up.PlaceId == pid)
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

    }
}
