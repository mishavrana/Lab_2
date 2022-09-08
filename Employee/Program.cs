namespace Employee
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create an enployee");
            foreach (var title in Enum.GetValues(typeof(Employee.Jobs)))
            {
                Console.WriteLine(title); 
            }
        }
     }
}
