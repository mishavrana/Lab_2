namespace Employee;

public class Employee
{
    private string name;
    private string surname;
    private int experience;
    private Jobs job;

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
            coutSalatry();
        }
    }

    public Jobs Job
    {
        get { return job; }
        set
        {
            job = value;
            coutSalatry();
        }
    }


    public int coutSalatry()
    {
        int salary = 0;
        switch (experience)
        {
            // for middle
            case > 5 and <= 10:
                salary.Procents(10); break;
            // for senior specialist 
            case > 10 and <= 40:
                salary.Procents(20); break;
            // for veteran 
            case > 40:
                salary.Procents(30); break;
        }
        
        switch (job)
        {
            case Jobs.Director:
                salary += 30_000; break; 
            case Jobs.HeadTeacher:
                salary += 25_000; break; 
            case Jobs.Teacher:
                salary += 20_000; break; 
            case Jobs.Housemaid:
                salary += 10_000; break; 
            case Jobs.Security:
                salary += 10_000; break; 
            
        }
        return salary;
    }
    public enum Jobs
    {
        Director,
        HeadTeacher, 
        Teacher, 
        Housemaid, 
        Security
    }

    public Employee(string name, string surname, int experience, Jobs job)
    {
        this.name = name;
        this.surname = surname;
        this.experience = experience;
        this.job = job;
    }
    
}