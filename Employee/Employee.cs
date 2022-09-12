namespace Employee;

public class Employee
{
    private string name;
    private string surname;
    private int experience = 20;
    private Jobs job = Jobs.Teacher;
    private int tax = 12;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public int Experience
    {
        get { return experience; }
        set
        {
            experience = value;
            CountSalaryAndTax();
        }
    }
    public Jobs Job
    {
        get { return job; }
        set
        {
            job = value;
            CountSalaryAndTax();
        }
    }
    public int Tax
    {
        get { return tax; }
        set
        {
            tax = value;
            CountSalaryAndTax();
        }
    }
    
    // Calculates salary and charge according to 'job', 'experience' and 'tax'
    public (int salary, int charge) CountSalaryAndTax()
    {
        int salary = 0;

        // Calculating 'salary'
        switch (experience)
        {
            // for middle
            case > 5 and <= 10:
                salary.PlusProcents(10);
                break;
            // for senior specialist 
            case > 10 and <= 40:
                salary.PlusProcents(20);
                break;
            // for veteran 
            case > 40:
                salary.PlusProcents(30);
                break;
        }

        switch (job)
        {
            case Jobs.Director:
                salary += 30_000;
                break;
            case Jobs.HeadTeacher:
                salary += 25_000;
                break;
            case Jobs.Teacher:
                salary += 20_000;
                break;
            case Jobs.Housemaid:
                salary += 10_000;
                break;
            case Jobs.Security:
                salary += 10_000;
                break;

        }

        // Calculating 'charge' according to 'salary'
        int charge = salary.Procents(tax);
        
        // Calculating income after charging the tax
        salary -= charge;
        return (salary, charge);
    }
    
    public enum Jobs
    {
        Director,
        HeadTeacher,
        Teacher,
        Housemaid,
        Security
    }
    
    public Employee(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
}