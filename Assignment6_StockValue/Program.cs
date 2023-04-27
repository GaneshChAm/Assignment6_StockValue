namespace Assignment6_StockValue
{
    internal class Furniture
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public void Accept()
        {
            Console.Write("Enter height: ");
            Height = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Enter color: ");
            Color = Console.ReadLine();

            Console.Write("Enter quantity: ");
            Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            Price = double.Parse(Console.ReadLine());


        }

        public void Display()
        {
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price: {Price}");
        }

        public double TotalCost()
        {
            return Quantity * Price;
        }
    }

    internal class BookShelf : Furniture
    {
        public int NoOfShelves { get; set; }

        public void Accept()
        {
            base.Accept();
            Console.Write("Enter No. of Shelves: ");
            NoOfShelves = int.Parse(Console.ReadLine());


        }

        public void Display()
        {
            Console.WriteLine("BookShelf Details:");
            base.Display();
            Console.WriteLine($"No. of Shelves: {NoOfShelves}");
        }
    }

    internal class DiningTable : Furniture
    {
        public int NoOfLegs { get; set; }

        public void Accept()
        {
            base.Accept();
            Console.Write("Enter No. of Legs: ");
            NoOfLegs = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Dining Table Details:");
            base.Display();
            Console.WriteLine($"No. of Legs: {NoOfLegs}");
        }
    }
    internal class Program
    {
        static void AcceptStockSetails(Furniture[] stock)
        {
            Console.WriteLine("Please select the type of furniture:");
            Console.WriteLine("1. Bookshelf");
            Console.WriteLine("2. Dining table");

            for (int i = 0; i < stock.Length; i++)
            {
                Console.Write($"Enter the type of furniture-{i + 1}: ");
                string furnitureType = Console.ReadLine();

                if (furnitureType.ToLower() == "bookshelf")
                {
                    BookShelf bookShelf = new BookShelf();
                    bookShelf.Accept();
                    stock[i] = bookShelf;
                }
                else if (furnitureType.ToLower() == "dining table")
                {
                    DiningTable diningTable = new DiningTable();
                    diningTable.Accept();
                    stock[i] = diningTable;
                }
                else
                {
                    Console.WriteLine("Invalid furniture type entered. Please try again.");
                    i--;
                    continue;
                }

                Console.WriteLine($"Furniture #{i + 1} details accepted.");
                Console.WriteLine();
            }
        }

        static double TotalStockPrice(Furniture[] stock)
        {
            double totalStockValue = 0;

            for (int i = 0; i < stock.Length; i++)
            {
                totalStockValue += stock[i].Price * stock[i].Quantity;
            }

            return totalStockValue;
        }
        static int ShowStockDetails(Furniture[] stock)
        {
            int i = 0;
            foreach (Furniture f in stock)
            {
                Console.WriteLine($"Furniture details {++i}:");
                f.Display();
                Console.WriteLine("----------------------------------------------------------------");
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Furniture[] stock = new Furniture[5];
            while (true)
            {
                Console.WriteLine("1:Accept Stock Details");
                Console.WriteLine("2:Display Total Stock Value");
                Console.WriteLine("3: Show all Stock Details");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AcceptStockSetails(stock);
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine($"Total Stock Value = {TotalStockPrice(stock)}");
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine(ShowStockDetails(stock));
                        Console.WriteLine("---------------------------------------------------------");
                        break;                   
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
}