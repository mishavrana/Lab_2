namespace Employee;

public static class StringExtention
{
    public static int Procents(this int integer, int procent)
    {
        int valueWithProcents = 0;
        return (valueWithProcents += (valueWithProcents / 100) * procent);
    }
}