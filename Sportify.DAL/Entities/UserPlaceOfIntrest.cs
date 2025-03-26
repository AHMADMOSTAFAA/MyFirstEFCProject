using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.DAL.Entities
{
    public class UserPlaceOfIntrest
    {
        public int PlaceId { get; set; }//fk
        public PlaceOfInterest Place {  get; set; } 
        public int UserId { get; set; }//fk
        public User User { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }  


    }
}
