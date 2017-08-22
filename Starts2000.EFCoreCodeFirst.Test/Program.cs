using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starts2000.EFCoreCodeFirst.Test
{
    static class Program
    {
        static void Main(string[] args)
        {
            using(var context = new TestDbContext())
            {
                context.User.Add(new Models.User
                {
                    Aaccount = "CodeFirst-Test-" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                    Password = "123456"
                });

                context.SaveChanges();

                Console.WriteLine(context.User
                    .OrderByDescending(u => u.Id)
                    .FirstOrDefault()?.Aaccount);
            }

            Console.ReadKey();
        }
    }
}
