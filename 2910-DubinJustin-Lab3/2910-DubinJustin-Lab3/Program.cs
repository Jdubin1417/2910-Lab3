class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        using (var reader = new StreamReader("data.csv"))
        {
            reader.ReadLine(); // Skip header line
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                var person = new Person
                {
                    FirstName = values[0],
                    LastName = values[1],
                    Address = new Address
                    {
                        StreetAddress = values[2],
                        City = values[3],
                        State = values[4],
                        PostalCode = values[5]
                    }
                };

                people.Add(person);
            }
        }

        people.Sort();

        using (var writer = new StreamWriter("data.psv"))
        {
            foreach (var person in people)
            {
                writer.WriteLine(person.ToString());
            }
        }
    }
}



