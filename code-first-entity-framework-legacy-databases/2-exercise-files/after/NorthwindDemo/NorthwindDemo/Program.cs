using System;
using System.Linq;
using NorthwindDemo.Data;

namespace NorthwindDemo
{
    static class Program
    {
        static void Main()
        {
            using (var db = new NorthwindDbContext())
            {
                var data = db.Categories;
                foreach (var item in data)
                {
                    Console.WriteLine(item.CategoryId + " " + item.CategoryName);
                }
                Console.WriteLine();

                var history = db.CustOrderHist("ALFKI");
                foreach (var item in history)
                {
                    Console.WriteLine("{0, 2} {1}", item.Total, item.ProductName);
                }

                Console.WriteLine();
                
                var orderDetail = db.OrderDetails.First();
                Console.WriteLine(orderDetail.Product.ProductName);

                Console.WriteLine();

                Console.WriteLine(db.GetSaveChangesCount());
                db.SaveChanges();
                db.SaveChanges();
                Console.WriteLine(db.GetSaveChangesCount());

                Console.WriteLine();
                var csvToInt = db.CsvToInt("2,4,6,8").Select(x => x.IntValue);
                foreach (var item in csvToInt)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
                var engineer = new Engineer
                {
                    Forename = "Simon",
                    Surname = "Hughes"
                };
                db.Engineers.Add(engineer);
                db.SaveChanges();

                var order = new EngineerOrder
                {
                    OrderPlaced = DateTime.Now,
                    Engineer = engineer
                };
                db.EngineerOrders.Add(order);
                db.SaveChanges();
            }
        }
    }
}
