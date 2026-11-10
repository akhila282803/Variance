public class SoupCart : StreetCartBase
{
    public override Soup Sell(Cash payment)
    {
        return new Soup();
    }

    public Soup Sell(Payment payment)
    {
        return new Soup();
    }
}