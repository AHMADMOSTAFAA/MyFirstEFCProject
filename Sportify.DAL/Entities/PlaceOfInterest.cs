using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.DAL.Entities
{
    public class PlaceOfInterest
    {
        public int Id { get; set; }//IDENTITY (1,1)
        [Required]
        public string PName { get; set; }
        [Required]
       
        public string Coordinates { get; set; }
        [Required]
     
        public string SportType {  get; set; }
        [Required]
      
        public string Address {  get; set; }
        public int ownerid { get; set; }//fk
        public User owner { get; set; }
        public string? ImgUrl {  get; set; }
        public ICollection<UserPlaceOfIntrest> UserPlaceOfIntrests { get; set; }

        public ICollection<Shop> Shops { get; set; } = new List<Shop>();


    }
}
