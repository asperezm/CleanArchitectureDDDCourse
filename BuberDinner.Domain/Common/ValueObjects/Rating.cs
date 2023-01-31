using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Common.ValueObjects;

public class Rating : ValueObject
{
    public int Value { get; private set;}

    private Rating(int value)
    {
        Value = value;
    }

    public static Rating CreateNew(int rating)
    {
        return new Rating(rating);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
