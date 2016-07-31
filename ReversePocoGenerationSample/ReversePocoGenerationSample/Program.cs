using ReversePocoGenerationSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePocoGenerationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestDbContext())
            {
                var data = db.Answers;
                foreach (var item in data)
                {
                    Console.WriteLine(item.AnswerValue + " " + item.Comment);
                }
                Console.WriteLine();


                ////stored Procedure
                //var history = db.CustOrderHist("ALFKI");
                //foreach (var item in history)
                //{
                //    Console.WriteLine("{0, 2} {1}", item.Total, item.ProductName);
                //}

                Console.WriteLine();

                var orderDetail = db.Questions.First();
                Console.WriteLine(orderDetail.Comment);

                Console.WriteLine();

                Console.WriteLine(db.GetSaveChangesCount());
                db.SaveChanges();
                db.SaveChanges();
                Console.WriteLine(db.GetSaveChangesCount());

                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
