
using Project.Core;
using System.Reflection;

var dllFile = @"C:\Users\turka\source\repos\Kurumsal\KaleGrup\Ileri C#\DeveloperLogging\Project.Entities\bin\Debug\net6.0\Project.Entities.dll";
var assembly = Assembly.LoadFile(dllFile);
foreach (var type  in assembly.GetTypes())
{
    developerInfoConsole(type);
}

void developerInfoConsole(Type type)
{
    Console.WriteLine("Yazılımcı bilgileri okunuyor");
    Console.WriteLine("-------------------------------");

    Attribute[] attributes = Attribute.GetCustomAttributes(type);

    foreach (var attribute in attributes)
    {
        if (attribute is DeveloperInfoAttribute)
        {
            var developerInfo = (DeveloperInfoAttribute)attribute;
            Console.WriteLine($"Sınıf adı: {type.Name}");
            Console.WriteLine($"Yazılımcı adı:{developerInfo.Name}");
            Console.WriteLine($"Yazılımcı açıklaması:{developerInfo.Description}");
            Console.WriteLine($"Kodun eklenme tarihi:{developerInfo.CreatedDate}");
            Console.WriteLine("*****************************************");

            var members = type.GetMembers();
            ShowMemberInfo(members);
        }

    }
}

void ShowMemberInfo(MemberInfo[] members)
{
    foreach (var member in members)
    {
        foreach (var attribute in member.GetCustomAttributes())
        {
            if (attribute is DeveloperInfoAttribute)
            {
                var developerInfo = (DeveloperInfoAttribute)attribute;
                Console.WriteLine($"Üye adı: {member.Name}");
                Console.WriteLine($"Üye Tipi: {member.MemberType}");
                Console.WriteLine($"Yazılımcı adı:{developerInfo.Name}");
                Console.WriteLine($"Yazılımcı açıklaması:{developerInfo.Description}");
                Console.WriteLine($"Kodun eklenme tarihi:{developerInfo.CreatedDate}");
                Console.WriteLine("*****************************************");

              
            }
        } 
     
    }
}