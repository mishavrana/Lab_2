namespace Lab1 {
    class Program { 
        
        static void Main(string[] args) 
        {
            Address address = new Address();
            address.indexNumber = 03256; 
            address.CountryName = "Ukraine"; 
            address.CityName = "Kyiv"; 
            address.StreetName = "Chervonotkatska"; 
            address.HouseNumber = 23; 
            address.ApartmentNumber = 105;

            Console.WriteLine
            (
                "Address is: {0}, {1}, {2}, {3} st., {4}, {5}",
                address.indexNumber,
                address.CityName,
                address.CountryName,
                address.StreetName,
                address.HouseNumber,
                address.ApartmentNumber
            );
        }
    }
}