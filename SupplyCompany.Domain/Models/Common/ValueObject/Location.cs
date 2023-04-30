namespace SupplyCompany.Domain.Models.Common;

public class Location : ValueObject {
    public string State { get; private set; }
    public string City { get; private set; }
    public string Address { get; private set; }

    public Location(
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
    public Location Copy() {
        return (Location)this.MemberwiseClone();
    }
    public static Location CreateFrom(Location nl) {
        return new(nl.State, nl.City, nl.Address);
    }
}