using Converter = converter.Converter;
using Currency = converter.Converter.Currency;
using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace lab_2 {
    class Programm {
        private static Converter uahConverter = new Converter
        (
            usdValue: 36.91,
            eurValue: 36.65,
            rubValue: 0.61,
            yourCurrensy: "UAH" 
        );

        static void Main(string[] args)
        {
            int? tuskNumber = null;
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
            Currency currency;
            double sum;
            Console.WriteLine("Choose currency to convert in (usd/eur/rub)");
            while (true)
            {
                string cy = Console.ReadLine()!;
                try
                {
                    switch (cy)
                    {
                        case "usd":
                            currency = Currency.Usd;
                            break;
                        case "eur":
                            currency = Currency.Eur;
                            break;
                        case "rub":
                            currency = Currency.Rub;
                            break;
                        default:
                            throw new NullReferenceException("Non existing currency");;
                    }

                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Enter the amount of money in {0}:", uahConverter.YourCurrensy);
                try
                {
                    sum = double.Parse(Console.ReadLine()!);
                    if (sum > 0)
                        break;
                    throw new Exception("Can't convert to 'double'");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(uahConverter.Convert(to: currency, sum));
            Console.ReadLine();
        }

        // Converts usd/eur/rub to UAH
        private static void ToUAHConverter()
        {
            Currency currency;
            double sum;
            Console.WriteLine("Enter the currency (usd/eur/rub)");
            while (true)
            {
                string cy = Console.ReadLine()!;
                try {
                    switch (cy)
                    {
                        case "usd":
                            currency = Currency.Usd;
                            break;
                        case "eur":
                            currency = Currency.Eur;
                            break;
                        case "rub":
                            currency = Currency.Rub;
                            break;
                        default:
                            throw new NullReferenceException("Non existing currency");
                    }
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true)
            {
                Console.WriteLine("Enter the amount of money is {0}:", currency);
                try
                {
                    sum = double.Parse(Console.ReadLine()!);
                    if (sum > 0)
                        break;
                    throw new Exception("Can't convert to 'double'");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(uahConverter.Convert(sum, of: currency));
            Console.ReadLine();
        }
    }
}
