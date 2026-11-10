public class SandwichCart : StreetCartBase
{
    public override Sandwich Sell(Cash payment)
    {
        return new Sandwich();
    }
}