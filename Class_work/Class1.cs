using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work
{
    internal class Sales
    {
        public int Id { get; set; }
        public string CatName { get; set; }

        public static List<Sales> GetSales()
        {
            return new List<Sales>
            {
                new Sales{CatName = "stationary", Id=2},
                new Sales{CatName ="Fruit", Id=6},
                new Sales{CatName ="Drink", Id=8},
                new Sales{CatName ="Bevarages", Id =10},
                new Sales{CatName ="Flours", Id=12}

            };
        }

    }

    public class Items
    {
        public int Rollnum { get; set; }
        public string ItemName { get; set; }
        
        public double Amount { get; set; }
        public int SalesId { get; set; }


            public static List<Items> GetItems()
            {
                  return new List<Items>
                  {
                      new Items{Rollnum =10, ItemName= "Books", Amount=500, SalesId =2 },
                      new Items{Rollnum =20, ItemName= "Bootle Fants", Amount = 150, SalesId=8},
                      new Items{Rollnum =30, ItemName= "Apple", Amount = 200, SalesId=6},
                      new Items{Rollnum =40, ItemName= "Bread", Amount = 650, SalesId=12},
                      new Items{Rollnum =60, ItemName= "Milo", Amount = 1000, SalesId=10},
                      new Items{Rollnum =80, ItemName= "Pencil", Amount = 500, SalesId=2},
                      new Items{Rollnum =2, ItemName= "San", Amount = 250, SalesId=8},
                      new Items{Rollnum =3, ItemName= "Pineapple", Amount = 2200, SalesId=6},
                      new Items{Rollnum =5, ItemName= "Rice", Amount = 5050, SalesId=12},
                      new Items{Rollnum =4, ItemName= "Cocoa", Amount = 1000, SalesId=10},
                      new Items{Rollnum =7, ItemName= "Chalk", Amount = 500, SalesId=2},
                      new Items{Rollnum =9, ItemName= "Cocacola", Amount = 150, SalesId=8},
                      new Items{Rollnum =1, ItemName= "Lemon", Amount = 200, SalesId =6 },
                      new Items{Rollnum =8, ItemName= "Cerael", Amount = 650,},
                     new Items{Rollnum =15, ItemName= "Chocolate", Amount = 1000,}



                  };
            }
    }
}
