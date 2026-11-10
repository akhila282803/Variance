using System;

class Program
{
    static void Main()
    {
        SandwichCart sandwichCart = new SandwichCart();
        Food sandwich = sandwichCart.Sell(new Cash());
        Console.WriteLine("SandwichCart: " + sandwich.GetType().Name);

        VietnameseCart vietnameseCart = new VietnameseCart();
        Food bahnMi = vietnameseCart.Sell(new Cash());
        Console.WriteLine("VietnameseCart: " + bahnMi.GetType().Name);

        ToastCart toastCart = new ToastCart();
        Food toast = toastCart.Sell(new Card());
        Console.WriteLine("ToastCart: " + toast.GetType().Name);

        SoupCart soupCart = new SoupCart();
        Food soup = soupCart.Sell(new Swish());
        Console.WriteLine("SoupCart: " + soup.GetType().Name);

        IceCreamCart iceCreamCart = new IceCreamCart();
        Food iceCream = iceCreamCart.Sell(new Cash());
        Console.WriteLine("IceCreamCart: " + iceCream.GetType().Name);
    }
}