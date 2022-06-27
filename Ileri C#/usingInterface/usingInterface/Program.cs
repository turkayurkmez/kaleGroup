// See https://aka.ms/new-console-template for more information
using usingInterface;

Console.WriteLine("Hello, World!");

Student student1 = new Student { Id = 1, Name = "Elif", LastName = "Külcü", Age = 27, AverageScore = 3.6 };
Student student2 = new Student { Id = 2, Name = "Türkay", LastName = "Ürkmez", Age = 42, AverageScore = 2.24 };
Student student3 = new Student { Id = 3, Name = "Emirhan", LastName = "Arslan", Age = 29, AverageScore = 2.28 };

ClassRoom classRoom = new ClassRoom();
classRoom.Add(student1);
classRoom.Add(student2);
classRoom.Add(student3);

classRoom.Sort();

foreach (var item in classRoom)
{
    Console.WriteLine($"{item.Name} {item.Age}");
}

var gun = new Riffle();
var gun2 = new KanasSniper();

if (gun2 is IZoomable)
{
    var zoomable = (IZoomable)gun2;
    zoomable.Zoom();
}
else
{
    throw new Exception($"{gun.ToString()} nesnesi Zoom interface'ini implemente etmiyor!");
}

