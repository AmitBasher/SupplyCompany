namespace SupplyCompany.Domain.Models.Common;

public sealed class AverageRatings : ValueObject
{
    public double Value { get; private set; }
    public int NumRatings { get; private set; }
    private AverageRatings(double value, int numRatings)
    {
        Value = value;
        NumRatings = numRatings;
    }
    public static AverageRatings CreateNew(double rating = 0, int numRatings = 0)
    {
        return new AverageRatings(rating, numRatings);
    }

    public void AddNewRating(Rating rating)
    {
        Value = ((Value * NumRatings) + rating.Value) / ++NumRatings;
    }

    public void RemoveRating(Rating rating)
    {
        Value = ((Value * NumRatings) - rating.Value) / --NumRatings;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}