using OperatorOverloading;

var number1 = 15;
var number2 = 18;

int total = number1 + number2;

var word1 = "Merhaba";
var word2 = "İnsanlık";

var sentence = word1 + word2;

var another = word1 + number2;
Console.WriteLine(another);

CartItem cartItem = new CartItem() { Name = "Tişört", Price = 50.99M, Quantity = 10 };
var result = 10.50M + cartItem;

CartItem first = new CartItem { Name = "Şort", Price = 20, Quantity = 2 };
CartItem second = new CartItem { Name = "Ayakkabı", Price=100, Quantity= 3 };
CartItem third = new CartItem { Name = "Güneş gözlüğü", Price = 500, Quantity = 1 };

var totalPrice = first + second;
Console.WriteLine($"iki ürünün toplam tutarı: {totalPrice}");

Console.WriteLine(result);

ShoppingCard shoppingCard = new ShoppingCard();
shoppingCard.AddToCart(first);
shoppingCard.AddToCart(second);
shoppingCard.AddToCart(third);
Console.WriteLine("sepetteki toplam ürün:");
Console.WriteLine(shoppingCard.GetTotalPrice()); 

