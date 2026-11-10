public class IceCreamCart : StreetCartBase
{
    public override IceCream Sell(Cash payment)
    {
        return new IceCream();
    }
}