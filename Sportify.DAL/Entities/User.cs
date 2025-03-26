using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location {  get; set; }
        public string Role {  get; set; }
        public List<UserProduct> UserProducts { get; set; } = new List<UserProduct>();//new nav 

        public ICollection<PlaceOfInterest>OwnerPlaces { get; set; }=new List<PlaceOfInterest>();
        public ICollection<UserPlaceOfIntrest> UserPlaceOfInterests { get; set; } = new List<UserPlaceOfIntrest>();

       
    }
}
