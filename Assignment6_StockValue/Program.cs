namespace Assignment6_StockValue
{
    class Furniture
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public void Acceptdetails()
        {
            Console.WriteLine("Enter the Height");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the color");
            string c = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Quantity");
            int q = Convert.ToInt32(Console.ReadLine());
        }
    }
    class BookShelf : Furniture
    {
        public int NoOfShelves { get; set; }
    }
    class DiningTable : Furniture
    {
        public int NoOfLegs { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}