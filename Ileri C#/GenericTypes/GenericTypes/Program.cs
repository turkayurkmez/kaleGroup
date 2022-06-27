// See https://aka.ms/new-console-template for more information
using GenericTypes;

Console.WriteLine("Hello, World!");
PointObject pointObject = new PointObject();
pointObject.X = "Deneme";
pointObject.Y = 10;

int x = (int)pointObject.X;

Point<char> point = new Point<char>();
