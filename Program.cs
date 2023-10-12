namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buses avtobus1 = new Buses("Mers",1999,20_000);
            Buses avtobus2 = new Buses("Volvo", 2000, 30_900.8m);
            Console.WriteLine("Boshlang'ich malumotlar");
            Console.WriteLine(avtobus1);
            Console.WriteLine();
            Console.WriteLine(avtobus2);
            Console.WriteLine("Oshgan narx");
            avtobus1.NarxniOshirish(1_000);
            Console.WriteLine();
            avtobus2.NarxniOshirish(2_9);
            Console.WriteLine(avtobus1);
            Console.WriteLine();
            Console.WriteLine(avtobus2);

        }
    }

    struct Buses
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Buses(string model, int year, decimal price)
        {
            Model = model;
            Year = year;
            Price = price;
        }

        public void NarxniOshirish(decimal narx)
        {
            Price += narx;
        }

        public override string ToString()
        {
            return $"{Year} yili\n {Model} model \n{Price:C3} narxi";
        }
        //    "C0": Valyutaning raqamli ko'rinishi, qoldiqsiz (masalan, 75000).
        // 
        // "C2": Valyutaning raqamli ko'rinishi, ikki qoldiq darajasi (masalan, 75000.00).
        // 
        // "C3": Valyutaning raqamli ko'rinishi, uch qoldiq darajasi (masalan, 75000.000).
        // 
        // "C4": Valyutaning raqamli ko'rinishi, to'rt qoldiq darajasi (masalan, 75000.0000).
        // 
        // "C": Valyutaning umumiy ko'rinishi (qoldiqli, qoldiqsiz, qo'shimcha so'zlar, masalan, "$75,000.00").
    }
}