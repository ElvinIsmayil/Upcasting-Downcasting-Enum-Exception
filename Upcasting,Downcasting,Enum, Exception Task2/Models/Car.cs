namespace Upcasting_Downcasting_Enum__Exception_Task2.Models
{
    public class Car
    {
        private static int _counter;
        public int Id { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Enum Type { get; set; }

        public Car()
        {
            Id = ++_counter;
        }
        public Car(string brand, string model, Enum type)
        {
            Id = ++_counter;
            Brand = brand;
            Model = model;
            Type = type;
        }

        public override string ToString()
        {
            return $"Id: {Id} , Brand: {Brand} , Model: {Model} , Type: {Type}";
        }
    }
}
