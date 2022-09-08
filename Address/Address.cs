public class Address
{
    private int index, house, apartment;
    private string country = "";
    private string city = "";
    private string street = "";

    public int indexNumber
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
    public int HouseNumber
    {
        get { return house; }
        set { house = value; }
    }
    public int ApartmentNumber
    {
        get { return apartment; }
        set { apartment = value; }
    }
}