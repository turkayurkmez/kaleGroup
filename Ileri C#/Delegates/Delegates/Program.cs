
using Delegates;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(".net 1.1");
var dotnet1 = FilteringObject.Filter(numbers, isEven);
show(dotnet1);
Console.WriteLine("-------------------");
Console.WriteLine(".net 2.0");

var dotnet2 = FilteringObject.Filter(numbers, delegate (int number) { return number % 3 == 0; });
show(dotnet2);
Console.WriteLine("-------------------");

Console.WriteLine(".net 3.0+");
var dotnet3 = FilteringObject.Filter(numbers, number =>  number % 4 == 0);
alternateShow(dotnet3);
Console.WriteLine("-------------------");




void show(int[] numbers)
{
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
}

void alternateShow(int[] numbers)
{
    numbers.ToList().ForEach(number => Console.WriteLine(number));
}

//çift sayıları filtrelemek istiyoruz.


//static int[] filter(int[] values)
//{
//    List<int> filteredResult = new List<int>();
//    foreach (var item in values)
//    {
//        if (isEven(item))
//        {
//            filteredResult.Add(item);
//        }
//    }

//    return filteredResult.ToArray();
//}

static bool isEven(int number)
{
    return number % 2 == 0;
}

static bool isOdd(int number)
{
    return number % 2 == 1;
}