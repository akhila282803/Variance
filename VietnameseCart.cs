public class VietnameseCart : StreetCartBase
{
    public override BahnMi Sell(Cash payment)
    {
        return new BahnMi();
    }
}