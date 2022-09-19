using System;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            Console.Write("Enter the index= ");
            address.Index = int.Parse(Console.ReadLine());

            Console.Write("Enter the country=");
            address.Country = Console.ReadLine();

            Console.Write("Enter the city= ");
            address.City = Console.ReadLine();

            Console.Write("Enter the street= ");
            address.Street = Console.ReadLine();

            Console.Write("Enter the house= ");
            address.House = Console.ReadLine();

            Console.Write("Enter the apartment= ");
            address.Apartment = int.Parse(Console.ReadLine());

            address.Print();
            Console.ReadLine();
        }        
    }
}

class Address
{
    private int index, apartment;
    private string country, city, street, house;
    public int Index
    {
        get { return index; }
        set
        {
            if (value > 0)
                index = value;
            else
                Console.WriteLine("Index can't be zero or negative!");
        }
    }
    public string Country
    { get { return country; } set { country = value; } }

    public string City
    { get { return city; } set { city = value; } }

    public string Street
    { get { return street; } set { street = value; } }

    public string House
    { get { return house; } set { house = value; } }

    public int Apartment
    {
        get { return apartment; }
        set
        {
            if (value > 0)
                apartment = value;
            else
                Console.WriteLine("The apartment cannot be a zero or negative!");
        }
    }

    public void Print()
    {
        Console.WriteLine($"\nIndex={index}, Country={country}, City={house}, Street={street}, House={house}, Apartment={apartment}");
        Console.ReadLine();
    }
}