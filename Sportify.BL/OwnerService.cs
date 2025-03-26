using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.BL
{
    public class OwnerService
    {
        DBContext dbContext=new DBContext();
        public void AddProd(string Prodname,string desc,int price,int shopid)
        {
            Product p = new Product() { 
            
            ProdName =Prodname,
            Description=desc,
            Price = price,
            ShopId = shopid
            };
            dbContext.Add(p);
            dbContext.SaveChanges();
        }
        public void DelProd(int id) { 
        var selectedProd=dbContext.products.FirstOrDefault(P => P.Id == id);
            dbContext.products.Remove(selectedProd);
            dbContext.SaveChanges();
        }
        public void UpdateProd(int id,string name,string desc,int price,int shpid)
        {
            var selectedProd = dbContext.products.FirstOrDefault(P => P.Id == id);
            selectedProd.ProdName = name;
            selectedProd.Description = desc;
            selectedProd.Price = price;
            selectedProd.ShopId = shpid;    
            dbContext.SaveChanges();
        }
    }
}
