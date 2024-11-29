namespace Upcasting_Downcasting_Enum__Exception_Task1.Models
{
    public class Room
    {
        private static int _counter;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;


        public Room(string name, decimal price, int personcapacity)
        {
            Id = ++_counter;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;

        }

        public void ShowInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Price: {Price} , PersonCapacity: {PersonCapacity} , IsAvailable: {IsAvailable}";
        }

    }
}
