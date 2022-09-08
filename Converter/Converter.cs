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
    public enum Currensy
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

    // Converts some preferred currency to uds/eur/Rub according to their values or returns 'null'
    public double? Convert(Currensy? to, double? yourCurrensy)
    {
        double? result = null;
        if(to.HasValue && yourCurrensy.HasValue)
        {
            switch (to)
            {
                case Currensy.Usd:
                    result = yourCurrensy / usd; break;
                case Currensy.Eur:
                    result = yourCurrensy / eur; break;
                case Currensy.Rub:
                    result = yourCurrensy / rub; break;
            }
        } 
        return (result);
    }

    // Converts usd/eur/Rub back to some preferred currency according to their value or returns 'null'
    public double? Convert(double? amount, Currensy? of)
    {
        double? result = null;
        if(amount.HasValue && of.HasValue)
        {
            switch (of)
            {
                case Currensy.Usd:
                    result = usd * amount; break;
                case Currensy.Eur:
                    result = eur * amount; break;
                case Currensy.Rub:
                    result = rub * amount; break;

            }
        }
        return (result);
    }
}