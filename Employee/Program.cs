using Employee = employee.Employee; 
namespace lab_2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Employee martin = new Employee(name: "Martin", surname: "Luther");
            PrintInformation(martin);
        }
        static void PrintInformation(Employee employee)
        {
            (int salary, int charge) employeeInformation = employee.CountSalaryAndTax();
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Surname: {employee.Surname}");
            Console.WriteLine($"Job: {employee.Job}");
            Console.WriteLine($"Salary: {employeeInformation.salary}");
            Console.WriteLine($"Charge: {employeeInformation.charge}");
        }
     }
}
