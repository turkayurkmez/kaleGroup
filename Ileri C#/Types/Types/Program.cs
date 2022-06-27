// See https://aka.ms/new-console-template for more information
using Types;

Console.WriteLine("Hello, World!");

byte value = 255;
byte minimum = 3;

//checked
//{
//    byte total = (byte)(value + minimum);
//    Console.WriteLine(total);
//}

//C# Tipi
string companyName = "Kale";
//.NET Tipi
String sirketAdi = "Kale";

int x = 8;
Int32 number = x;
var direction = Direction.Left;

switch (direction)
{
    case Direction.Up:
        break;
    case Direction.Down:
        break;
    case Direction.Left:
        break;
    case Direction.Right:
        break;
    default:
        break;
}

Console.WriteLine((int)direction);
ErkekAkrabalikTipleri erkek = ErkekAkrabalikTipleri.Ogul | ErkekAkrabalikTipleri.Abi | ErkekAkrabalikTipleri.Baba | ErkekAkrabalikTipleri.Dayı | ErkekAkrabalikTipleri.Amca;

Console.WriteLine(erkek);