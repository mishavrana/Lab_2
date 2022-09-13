using Address = address.Address;
namespace lab_2
{
    internal static class Program { 
        
        private static void Main(string[] args) 
        {
            Address address = new Address
            {
                IndexNumber = "03256",
                CountryName = "Ukraine",
                CityName = "Kyiv",
                StreetName = "Chervonotkatska",
                HouseNumber = "21",
                ApartmentNumber = "124"
            };
            Console.WriteLine
            (
                "Address is: {0}, {1}, {2}, {3} st., {4}, {5}",
                address.IndexNumber,
                address.CityName,
                address.CountryName,
                address.StreetName,
                address.HouseNumber,
                address.ApartmentNumber
            );
        }
    }
}


