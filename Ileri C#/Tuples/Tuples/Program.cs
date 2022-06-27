// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int output = 0;
int result = divide(15, 4, out output);
Console.WriteLine($"Sonuç: {result}, kalan {output}");

var alternatif1 = alternativeDivide(15, 2);
Console.WriteLine($"Sonuç: {alternatif1.Result}, kalan {alternatif1.Modulo}");

var alternatif2 = tupleDivide(18, 4);
Console.WriteLine($"Sonuç: {alternatif2.Item1}, kalan: {alternatif2.Item2}");


static int divide(int x, int y, out int modulo)
{
    modulo = x % y;
    return x / y;

}

static DivideResult alternativeDivide(int x, int y)
{
    return new DivideResult
    {
        Modulo = x % y,
        Result = x / y
    };
}


static Tuple<int,int> tupleDivide(int x, int y)
{
    return Tuple.Create<int, int>(x / y, x % y);
}

public class DivideResult
{
    public int Result { get; set; }
    public int Modulo { get; set; }
}