using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Cusomer cusomer = new Cusomer()
            {
                Id = 12, Name = "ehsan", Family = "shahsevani"
            };
            Product product = new Product();

            //new changes with print 1 Customer And order
            Order order = new Order();
            order.Id = 12;
            Console.WriteLine("{0} : {1} - {2} Id Customer : {3}",order.Id,cusomer.Name,cusomer.Family,cusomer.Id);

        }
    }
}
