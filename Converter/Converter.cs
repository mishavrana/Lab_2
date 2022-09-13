namespace converter
{
    public class Converter
    {
        private static double usd;
        private static double eur;
        private static double rub;
        private string yourCurrensy;
    
        public string YourCurrensy
        {
            get { return yourCurrensy; }
        }
    
        // Stores types of currency that matches only fields that are presented in 'Converter' class 
        public enum Currency
        {
            Usd, Eur, Rub
        }
    
        public Converter(double usdValue, double eurValue, double rubValue, string yourCurrensy)
        {
            usd = usdValue;
            eur = eurValue;
            rub = rubValue;
            this.yourCurrensy = yourCurrensy;
        }
    
        // Converts some preferred currency to uds/eur/rub according to their values or returns 'null'
        public double Convert(Currency to, double yourCurrensy)
        {
            double result = 0;
            switch (to)
            {
                case Currency.Usd:
                    result = yourCurrensy / usd; break;
                case Currency.Eur:
                    result = yourCurrensy / eur; break;
                case Currency.Rub:
                    result = yourCurrensy / rub; break;
                default: break;;
            }
            return (Math.Round(result, 2));
        }
    
        // Converts usd/eur/Rub back to some preferred currency according to their value or returns 'null'
        public double Convert(double amount, Currency of)
        {
            double result = 0;
            switch (of)
            {
                case Currency.Usd:
                    result = usd * amount; break;
                case Currency.Eur:
                    result = eur * amount; break;
                case Currency.Rub:
                    result = rub * amount; break;
                default: break;;
    
            }
            return (Math.Round(result, 2));
        }
    }
}
