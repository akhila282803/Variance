public class ToastCart : StreetCartBase
{
    public override GrilledCheese Sell(Cash payment)
    {
        return new GrilledCheese();
    }

    public GrilledCheese Sell(Payment payment)
    {
        return new GrilledCheese();
    }
}