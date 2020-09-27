using System;
using TestGit.files;

namespace TestGit
{
    class Program
    {
        public delegate void F1();

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

            F1 Sum = () => { Console.WriteLine(2 + 8); };
            F1 Sub = () => { Console.WriteLine(2 - 8); };
            F1 Mul = () => { Console.WriteLine(2 * 8); };
            F1 Pow = () => { Console.WriteLine(Math.Pow(2 , 8)); };

            NewClass newClass = new NewClass(15, "ehsan", "Shahsevani");
            Console.WriteLine("{0}: {1} {2}",newClass.Id,newClass.Name,newClass.LastName);
        }
    }
}
