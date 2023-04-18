using SupplyCompany.Domain.Models.Common;

namespace SupplyCompany.Domain.Models.Customer;

public sealed class Location : ValueObject
{
    public string State { get; }
    public string City { get; }
    public string Address { get; }

    private Location(
        string state,
        string city,
        string address)
    {
        State = state;
        City = city;
        Address = address;
    }

    public static Location CreateNew(
        string state,
        string city,
        string addreas)
    {
        return new(
            state,
            city,
            addreas);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return State;
        yield return City;
        yield return Address;
    }
}