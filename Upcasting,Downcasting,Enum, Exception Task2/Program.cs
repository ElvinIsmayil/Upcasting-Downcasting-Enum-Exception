using Upcasting_Downcasting_Enum__Exception_Task2.Models;

namespace Upcasting_Downcasting_Enum__Exception_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Brand = "BMW",
                Model = "F10",
                Type = Type.Sedan
                
            };

            Car car2 = new Car()
            {
                Brand = "Toyota",
                Model = "Rav4",
                Type = Type.SUV
            };

            Console.WriteLine(car1);
            Console.WriteLine(car2);







        }



    }
}
