using System;
using System.Diagnostics;
using System.Linq;

namespace FilteringDemo
{
    static class Program
    {
        static void Main()
        {
            var sw = new Stopwatch();

            sw.Start();
            using (var db = new Db())
            {
                var data = db.Companies.ToList();
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds / 1000.0);



            sw.Restart();
            using (var db = new Db())
            {
                var data = db.Companies.ToList();
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds / 1000.0);
        }
    }
}
