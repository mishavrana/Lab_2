using static Converter;
using System;
using Currensy = Converter.Currensy;
namespace lab_2 {
    class Programm {
        private static int? tuskNumber = null;
        private static Currensy? currensy = null;
        private static double? sum = null;
        private static Converter uahConverter = new Converter
        (
            usdValue: 36.91,
            eurValue: 36.65,
            rubValue: 0.61,
            yourCurrensy: "UAH" 
        );

        static void Main(string[] args) 
        {
            Console.WriteLine("Choose the financial operation");
            Console.WriteLine("1 - Convert UAH to usd/eur/Rub");
            Console.WriteLine("2 - Convert usd/eur/Rub to {0}", uahConverter.YourCurrensy);

            while (true)
            {
                try
                {
                    tuskNumber = int.Parse(Console.ReadLine()!);
                }
                catch
                {
                    Console.WriteLine("Can't convert to 'int'");
                }
                
                if (tuskNumber == 1 || tuskNumber == 2)
                {
                    break;
                }
            }

            switch (tuskNumber!)
            {
                case 1:
                    FromUAHConverter();
                    break;
                case 2:
                    ToUAHConverter();
                    break;
                default:
                    Console.WriteLine("Something went wrong"); break;
            }
        }

        // Converts to usd/eur/Rub from UAH
        private static void FromUAHConverter()
        {
            Console.WriteLine("Choose currency to convert in (usd/eur/Rub)");
            while (true)
            {
                string cy = Console.ReadLine()!;
                if (cy == "usd" | cy == "eur" || cy == "Rub")
                {
                    switch (cy)
                    {
                        case "usd":
                            currensy = Currensy.Usd;
                            break;
                        case "eur":
                            currensy = Currensy.Eur;
                            break;
                        case "Rub":
                            currensy = Currensy.Rub;
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the valid currensy");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter the amount of money in {0}:", uahConverter.YourCurrensy);
                try
                {
                    sum = double.Parse(Console.ReadLine()!);
                    break;
                }
                catch
                {
                    Console.WriteLine("Can't convert to 'double'");
                }
            }

            // Checked 'currensy' & 'sum' for values 
            if (currensy.HasValue && sum.HasValue)
            {
                Console.WriteLine(uahConverter.Convert(to: currensy!, sum!));
                Console.ReadLine();
            }
        }

        // Converts usd/eur/Rub to UAH
        static private void ToUAHConverter()
        {
            Console.WriteLine("Enter the currency (usd/eur/Rub)");
            while (true)
            {
                string cy = Console.ReadLine()!;
                if (cy == "usd" | cy == "eur" || cy == "Rub")
                {
                    switch (cy)
                    {
                        case "usd":
                            currensy = Currensy.Usd;
                            break;
                        case "eur":
                            currensy = Currensy.Eur;
                            break;
                        case "Rub":
                            currensy = Currensy.Rub;
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the valid currensy");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter the amount of money is {0}:", currensy);
                try
                {
                    sum = double.Parse(Console.ReadLine()!);
                    break;
                }
                catch
                {
                    Console.WriteLine("Can't convert to 'double'");
                }
            }
            // Checked 'sum' & 'currunsy' for values
            if (sum.HasValue && currensy.HasValue)
            {
                Console.WriteLine(uahConverter.Convert(sum!, of: currensy!));
                Console.ReadLine();
            } 
        }
    }
}
