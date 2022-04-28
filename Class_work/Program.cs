using System;
using System.Linq;
using System.Collections.Generic;
namespace Class_work
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sales = Sales.GetSales();
            var items = Items.GetItems();

            var groupjoin = sales.GroupJoin(items,
                b => b.Id,
                x => x.SalesId, (ysale, yitem) => new
                {
                    ysale.Id,
                    ysale.CatName,
                   yitem

                });
            foreach (var item in groupjoin)
            {
                Console.WriteLine($"itemId:{item.Id} itemCatName:{item.CatName}");
                foreach (var item2 in item.yitem)
                {
                    Console.WriteLine($"rollnum:{item2.Rollnum} ItemName: {item2.ItemName} Amount:{item2.Amount} saleId:{item2.SalesId}");
                }
            }
            var summ =Items.GetItems().Sum(x => x.Amount);
            Console.WriteLine($"sum = {summ}");

            var avg = Items.GetItems().Average(x => x.Rollnum);
            Console.WriteLine($"average= {avg}");
        }
    }
}

