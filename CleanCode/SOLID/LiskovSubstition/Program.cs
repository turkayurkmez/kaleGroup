// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var rectangle = Get(8,4);

Console.WriteLine(rectangle.GetArea());



static IAreaCalcutable Get(int width, int height=1)
{
    //farz edin işlemlerden geçti
    if (height > 1)
    {

        return new Rectangle() {  Width=width, Height=height};
    }
    return new Square() {  Width=width};

}

public interface IAreaCalcutable
{
    int GetArea();
}
public class Rectangle : IAreaCalcutable
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : IAreaCalcutable
{

    public int Width { get; set; }

    public int GetArea()
    {
        return Width * Width;  
    }
}