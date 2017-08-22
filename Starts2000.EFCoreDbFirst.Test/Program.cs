using System;
using System.Linq;

namespace Starts2000.EFCoreDbFirst.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestDbContext())
            {
                context.User.Add(new User
                {
                    Aaccount = "DbFirst-Test-" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
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
