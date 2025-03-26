using Microsoft.EntityFrameworkCore;
using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.BL
{
    public class UserService
    {
        DBContext dbContext = new DBContext();
        public void addUser(string name,string password,string location,string email,string role)
        {
            User user = new User()
            {
                Name = name,
                Password = password,
                Location = location,
                Email = email,
                Role = role
            };
            dbContext.users.Add(user);
            dbContext.SaveChanges();
            
        }//AKA Register
        public void Book(int pid,int uid,DateTime dateTime,DateTime enddate,decimal price) { 
        UserPlaceOfIntrest userPlaceOfIntrest = new UserPlaceOfIntrest() {
        PlaceId = pid,
        UserId = uid,
        ReservationDate = dateTime,
        EndDate = enddate,
        Price = price   
        };
            dbContext.userPlaceOfIntrests.Add(userPlaceOfIntrest);
            dbContext.SaveChanges();
        }
        public void CancelReservation(int pid,int uid) {
            var selectedreservation = dbContext.userPlaceOfIntrests.Where(up => up.UserId == uid && up.PlaceId == pid).FirstOrDefault();
            dbContext.userPlaceOfIntrests.Remove(selectedreservation);
            dbContext.SaveChanges();
        }

        public void AddProductToCart(int userId, int productId, int quantity)
        {
            var existingProduct = dbContext.UserProducts
                .FirstOrDefault(up => up.UserId == userId && up.ProductId == productId);

            if (existingProduct != null)
            {
                // If product already exists in cart, update quantity
                existingProduct.Quantity += quantity;
            }
            else
            {
                // If product is new, add it to the cart
                var newUserProduct = new UserProduct
                {
                    UserId = userId,
                    ProductId = productId,
                    Quantity = quantity
                };
                dbContext.UserProducts.Add(newUserProduct);
            }

            dbContext.SaveChanges();
        }

        public void RemoveProductFromCart(int userId, int productId, int quantity)
        {
            var existingProduct = dbContext.UserProducts
                .FirstOrDefault(up => up.UserId == userId && up.ProductId == productId);

            if (existingProduct != null)
            {
                if (existingProduct.Quantity > quantity)
                {
                    // Reduce quantity
                    existingProduct.Quantity -= quantity;
                }
                else
                {
                    // Remove product if quantity becomes 0 or less
                    dbContext.UserProducts.Remove(existingProduct);
                }

                dbContext.SaveChanges();
            }
        }


    }
}
