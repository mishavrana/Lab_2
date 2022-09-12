namespace user 
{ 
    class User 
    { 
        private string login; 
        private string name; 
        private string surname;
        private int age; 
        private readonly string dateOfSinghningTheForm;

        public string Login
        { 
            get { return login; }
            set { login = value; }
        }

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

        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public string DateOfSinghningTheForm
        { 
            get { return dateOfSinghningTheForm; }
        }

        public User (string login,
                     string name,
                     string surname,
                     int age,
                     string date)
        {
            this.login = login;
            this.name = name; 
            this.surname = surname;
            this.age = age; 
            dateOfSinghningTheForm = date;
        }
    }
}