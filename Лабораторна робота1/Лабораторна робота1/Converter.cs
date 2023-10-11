using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота1
{ 
using System;

public class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main(string[] args)

        {
        Console.OutputEncoding = Encoding.UTF8;

        Address address = new Address();
        address.Index = "55545";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Вул.Незалежності";
        address.House = "1";
        address.Apartment = "10";

        Console.WriteLine("Поштова адреса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

        Console.ReadKey();
    }
}
}
