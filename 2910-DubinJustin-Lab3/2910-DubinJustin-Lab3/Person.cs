using System.Net;

public class Person : IComparable<Person>
{
    public string FirstName { get; init; }
    public string LastName { get; set; }
    public Address Address { get; set; }

    public int CompareTo(Person other)
    {
        return LastName.CompareTo(other.LastName);
    }

    public override string ToString()
    {
        return $"{FirstName}|{LastName}|{Address}";
    }
}