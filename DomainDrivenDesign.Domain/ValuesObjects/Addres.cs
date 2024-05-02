namespace DomainDrivenDesign.Domain.ValuesObjects;

public partial record Addres
{
    public Addres(string country, string line1, string line2, string city, string state, string zipCope)
    {
        Country = country;
        Line1 = line1;
        Line2 = line2;
        City = city;
        State = state;
        ZipCope = zipCope;
    }

    public string Country { get; init; }
    public string Line1 { get; init; }
    public string Line2 { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string ZipCope { get; init; }

    public static Addres? Create(string country, string line1, string line2, string city, string state, string zipCode)
    {
        if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(line1)
                                          || string.IsNullOrEmpty(line2) || string.IsNullOrEmpty(city) ||
                                          string.IsNullOrEmpty(state) || string.IsNullOrEmpty(state)) return null;

        return new Addres(country , line1, line2, city, state,zipCode);
    }
}