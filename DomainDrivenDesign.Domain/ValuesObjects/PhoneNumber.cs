using System.Text.RegularExpressions;

namespace DomainDrivenDesign.Domain.ValuesObjects;

public partial record PhoneNumber
{
    private const int DefaultLenght = 12;

    private const string Pattern = @"^(829|849|809)-[0-9]{3}-[0-9]{4}$";

    private PhoneNumber(string value) => Value = value;

    public static PhoneNumber? Create(string value)
    {
        if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) ||
            value.Length != DefaultLenght) return null;

        return new PhoneNumber(value);
    }
    public string Value { get; init; }

    [GeneratedRegex(Pattern)]
    private static partial Regex PhoneNumberRegex();
}