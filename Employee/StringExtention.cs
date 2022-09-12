namespace Employee;

public static class StringExtention
{
    public static int PlusProcents(this int integer, int procent)
    {
        return (integer += integer / 100 * procent);
    }

    public static int Procents(this int integer, int procent)
    {
        return (integer * procent / 100);
    }
}