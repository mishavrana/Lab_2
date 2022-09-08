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

    // Stores types of currensy that matches only fields that are presented in 'Converter' class 
    public enum Currensy
    {
        usd, eur, rub
    }

    public Converter(double usdValue, double eurValue, double rubValue, string yourCurrensy)
    {
        usd = usdValue;
        eur = eurValue;
        rub = rubValue;
        this.yourCurrensy = yourCurrensy;
    }

    // Converts some prefered currensy to uds/eur/rub according to their values
    public double? Convert(Currensy? to, double? yourCurrensy)
    {
        double? result = null;
        if(to.HasValue && yourCurrensy.HasValue)
        {
            switch (to)
            {
                case Currensy.usd:
                    result = yourCurrensy / usd; break;
                case Currensy.eur:
                    result = yourCurrensy / eur; break;
                case Currensy.rub:
                    result = yourCurrensy / rub; break;
            }
        } 
        return (result);
    }

    // Converts usd/eur/rub back to some prefered currency according to their values
    public double? Convert(double? amount, Currensy? of)
    {
        double? result = null;
        if(amount.HasValue && of.HasValue)
        {
            switch (of)
            {
                case Currensy.usd:
                    result = usd * amount; break;
                case Currensy.eur:
                    result = eur * amount; break;
                case Currensy.rub:
                    result = rub * amount; break;

            }
        }
        return (result);
    }
}