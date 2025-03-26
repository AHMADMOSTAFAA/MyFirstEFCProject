using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.BL
{
    
    public class AdminService
    {
       DBContext dbContext=new DBContext();

        public List<UserPlaceOfIntrest>ShowReservations(int UID)
        {
          return  dbContext.userPlaceOfIntrests.Select(up => up).Where(up =>up.UserId== UID).ToList();
        }
        public List<PlaceOfInterest>ShowPlaces(int UID)
        {
            return dbContext.placeOfInterests.Select(p => p).Where(p =>p.ownerid==UID ).ToList();
        }

        public List<object> ShowReservationsInplace(int PID)
        {
            return dbContext.userPlaceOfIntrests.Select(up => new {PlaceId=up.PlaceId, username=up.User.Name,reservation_date=up.ReservationDate,up.EndDate,price=up.Price }).Where(up => up.PlaceId== PID).ToList<object>();
        }
        #region User
        public void DeleteUser(int UID)
        {
            var selecteduser = dbContext.users.FirstOrDefault(u => u.Id == UID);
            dbContext.users.Remove(selecteduser);
            dbContext.SaveChanges();
        }
        public bool UpdateUser(int UID, string? name, string? email, string? location, string? role)
        {
            var user = dbContext.users.FirstOrDefault(u => u.Id == UID);

            if (user == null)
                return false; // 🚨 No user found, return failure

            // ✅ Only update fields if new values are provided
            if (!string.IsNullOrEmpty(name)) user.Name = name;
            if (!string.IsNullOrEmpty(email)) user.Email = email;

            if (!string.IsNullOrEmpty(location)) user.Location = location;
            if (!string.IsNullOrEmpty(role)) user.Role = role;

            dbContext.SaveChanges();
            return true; // ✅ Update successful
        }
        #endregion
        #region Place
        public void AddPlace(string placename,string coor , string spType,string address,int oid,string? img)
        {
            PlaceOfInterest place = new PlaceOfInterest() { 
            PName = placename,
            Coordinates = coor,
            SportType = spType,
            Address = address,
            ownerid=oid,
            ImgUrl=img
            };
            dbContext.placeOfInterests.Add(place);
            dbContext.SaveChanges();
        }
       public void DelPlace(int id)
        {
            var place = dbContext.placeOfInterests.FirstOrDefault(place => place.Id == id);
            dbContext.placeOfInterests.Remove(place);
            dbContext.SaveChanges();
        }
        public bool UpdatePlace(int? id,string? pname,string? coor,string? stype,string? address,int oid,string?img)
        {
            var place = dbContext.placeOfInterests.FirstOrDefault(place => place.Id == id);
            if (place == null)
                return false; // 🚨 No user found, return failure

            // ✅ Only update fields if new values are provided
            if (!string.IsNullOrEmpty(pname)) place.PName = pname;
            if (!string.IsNullOrEmpty(coor)) place.Coordinates = coor;

            if (!string.IsNullOrEmpty(stype)) place.SportType = stype;
            if (!string.IsNullOrEmpty(address)) place.Address = address;
            if (!string.IsNullOrEmpty(img)) place.ImgUrl = img;
            if (oid!=null) place.ownerid = oid;
            
                

            dbContext.SaveChanges();
            return true; // ✅ Update successful
        }
        #endregion
        #region Shop
        public void AddShop(string ShopName,int PlaceId)
        {
            Shop shop = new Shop()
            {
                
                ShopName = ShopName,
                PlaceId = PlaceId
            };
            dbContext.shops.Add(shop);
            dbContext.SaveChanges();
        }
        public void DeleteShop(int ID) {
            var selectedshop = dbContext.shops.FirstOrDefault(s => s.Id == ID);
            dbContext.shops.Remove(selectedshop);
            dbContext.SaveChanges();
        }

        public void UpdateShop(int id,string name,int pid) {
            var selectedshop=dbContext.shops.FirstOrDefault(u => u.Id == id);
           selectedshop.ShopName = name;
            selectedshop.PlaceId = pid;
            dbContext.SaveChanges();
        }
        
        #endregion


    }
}
