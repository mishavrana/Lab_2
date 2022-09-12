namespace user
{
    class Program 
    {
        static void Main(string[] args) 
        { 
            User userOne = new User
            (
                login: "user1",
                name: "Denis",
                surname: "House",
                age: 20,
                date: "12.02.1968"
            );
            PrintTheInformation(user: userOne);
        }

        static void PrintTheInformation(User user)
        { 
            Console.WriteLine($"Login: {user.Login}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Surname: {user.Surname}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"Date of signing the form: {user.DateOfSinghningTheForm}");
        }
    }
}
