namespace address
{
    public class Address
    {
        private string index = "";
        private string country = "";
        private string city = "";
        private string street = "";
        private string house = "";
        private string apartment = "";

        public string IndexNumber
        {
            get { return index; }
            set { index = value; }
        }
        public string CountryName
        {
            get { return country; }
            set { country = value; }
        }
        public string CityName
        {
            get { return city; }
            set { city = value; }
        }
        public string StreetName
        {
            get { return street; }
            set { street = value; }
        }
        public string HouseNumber
        {
            get { return house; }
            set { house = value; }
        }
        public string ApartmentNumber
        {
            get { return apartment; }
            set { apartment = value;  }
        }
    }
}

