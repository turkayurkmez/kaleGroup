using ExtensionMethods;

string companyName = "Dinamik Zihin";
Console.WriteLine(companyName.RemoveSpaces());

string name = "türkay ÜRKMEZ";
Console.WriteLine(name.TitleCase()); ;
int counter = 0;
while (counter<=10)
{
    var password = new Random().PasswordGenerator(8);
    Console.WriteLine(password);
    counter++;
}
