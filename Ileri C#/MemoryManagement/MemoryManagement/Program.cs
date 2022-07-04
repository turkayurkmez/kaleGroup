
using MemoryManagement;
using System.Text;

Console.WriteLine($"Boş durumda: {GC.GetTotalMemory(true)}");
Random random = new Random();
int randomNumber = random.Next(100);
Console.WriteLine($"Random objesi: {GC.GetTotalMemory(true)}");
Product product = new Product { Id = 1, Name = "Tişört", Price = 120 };
Console.WriteLine($"Product: {GC.GetTotalMemory(true)}");
int primitive = 5678;
Console.WriteLine($"Primitive: {GC.GetTotalMemory(true)}");
GC.Collect();
GC.WaitForPendingFinalizers();
var total = GC.GetTotalMemory(true);

Console.WriteLine("OK");

using FileProcess fileProcess = new FileProcess();
var array = Encoding.UTF8.GetBytes("Merhaba bu bir cümledir");
fileProcess.WriteToFile(array);
fileProcess.ZippedFile("zippedFile.zip");