using Practice1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice1
{
    class Program
    {
        public db_test_1Entities db = new db_test_1Entities();
        static void Main(string[] args)
        {
            
            using(var context = new db_test_1Entities())
            {
                table1 lul = new table1();
                lul.name = "Hola2";

                var query = context.table1.Find(2);

                //foreach(var row in query)
                //{
                //    Console.WriteLine(row.name);
                //}

                Console.WriteLine(query.id + " - " + query.name);

                context.table1.Add(lul);
                context.SaveChanges();
            }
            Console.WriteLine("holiz");
            Console.ReadLine();
        }
    }
}
