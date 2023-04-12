public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }

    public override string ToString()
    {
        return $"{StreetAddress}|{City}|{State}|{PostalCode}";
    }
}