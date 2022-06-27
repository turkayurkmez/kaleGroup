// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer = new Customer() { Name = "Türkay", CartType = new Premium() };
OrderManager orderManager = new OrderManager { Customer = customer };
Console.WriteLine(orderManager.GetPayment(1000));

//Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
//Eğer yeni bir özellik eklemek istediğinizde nesne içinde değişiklik yapıyorsanız değişime uymuyorsunuz demektir.
//

public abstract class CartType
{
    public abstract decimal GetDiscountedPrice(decimal total);
    
}

public class Standart : CartType
{
    public override decimal GetDiscountedPrice(decimal total)
    {
        return total * .95m;

    }
}

public class Silver : CartType
{
    public override decimal GetDiscountedPrice(decimal total)
    {
        return total * .90m;

    }
}

public class Gold : CartType
{
    public override decimal GetDiscountedPrice(decimal total)
    {
        return total * .85m;

    }
}

public class Premium : CartType
{
    public override decimal GetDiscountedPrice(decimal total)
    {
        return total * .80m;

    }
}
public class Customer
{
    public string Name { get; set; }
    public CartType CartType { get; set; }
}

public class OrderManager
{
    public Customer Customer { get; set; }
    public decimal GetPayment(decimal totalPrice)
    {
        return Customer.CartType.GetDiscountedPrice(totalPrice);
        //switch (Customer.CartType)
        //{
        //    case CartTypes.Standard:
        //        return totalPrice * 0.95m;                 
        //    case CartTypes.Silver:
        //        return totalPrice * 0.90m;               
        //    case CartTypes.Gold:
        //        return totalPrice * 0.85m;
        //    case CartTypes.Premium:
        //        return totalPrice * 0.80m;
        //    default:
        //        return totalPrice;
        //}
    }
}


