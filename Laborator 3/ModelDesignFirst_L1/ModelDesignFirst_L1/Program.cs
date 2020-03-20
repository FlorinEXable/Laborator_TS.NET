using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestManyToMany();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {

                Person p = new Person()
                {
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    MiddleName = Console.ReadLine(),
                    TelephoneNumber = Console.ReadLine()
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }
        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (Model2Container context =
           new Model2Container())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

        static void TestManyToMany()
        {
            using (Model3Container context =
           new Model3Container())
            {
                Album a = new Album()
                {
                    AlbumName = "Change"
                };
                Artist ar = new Artist()
                {
                    FirstName = "Eminem",
                    LastName = "Eminem"
                };
                context.Albums.Add(a);
                context.Artists.Add(ar);
                context.SaveChanges();
                var items = context.Albums;
                foreach (var x in items)
                {
                    Console.WriteLine("Album : {0}",
                                      x.AlbumName);
                }
                var items2 = context.Artists;
                foreach (var x in items2)
                {
                    Console.WriteLine("Artist : {0}, {1}",
                                      x.FirstName, x.LastName);
                }
            }
        }

    }
}
