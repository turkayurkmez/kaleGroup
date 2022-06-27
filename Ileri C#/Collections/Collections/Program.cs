// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");

ArrayList arrayList = new ArrayList();

arrayList.Add(5);
arrayList.Add("Türkay");


List<string> cities = new List<string>();
cities.Add("Samsun");
cities.Add("Çanakkale");
cities.Add("Eskişehir");

var oldCities = new List<string>();
oldCities.AddRange(cities);
foreach (var item in oldCities)
{

    Console.WriteLine(item);
    //oldCities.Add(item);
    cities.Remove(item);

}

foreach (var item in oldCities)
{
    cities.Remove(item);
}





/* Tükenen koleksiyonlar */

Queue<string> queueMailList = new Queue<string>();
queueMailList.Enqueue("elif.kulcu@kalegrup.com.tr");
queueMailList.Enqueue("turkay.urkmez@dinamikzihin.com");
queueMailList.Enqueue("ali.veli@dinamikzihin.com");


while (queueMailList.Count > 0)
{
    var mail = queueMailList.Dequeue();
    Console.WriteLine(mail);
}

Stack<string> countries = new Stack<string>();
countries.Push("Türkiye");
countries.Push("Arjantin");
countries.Push("İsveç");

while (countries.Count > 0)
{
    var country = countries.Pop();
    Console.WriteLine(country);
}

Dictionary<string, string> plates = new Dictionary<string, string>();
string plate = string.Empty;
do
{
    Console.WriteLine("Plaka giriniz (çıkmak için q)");
    plate = Console.ReadLine();
    if (plate != "q")
    {
        Console.WriteLine("İl adını giriniz");
        var city = Console.ReadLine();
        if (plates.ContainsKey(plate))
        {
            Console.WriteLine("Bu plaka zaten kayıtlı");
        }
        else
        {
            plates.Add(plate, city);
        }
    }
} while (plate != "q");

string code = string.Empty;
do
{
    Console.WriteLine("Aradığınız plaka kodu (çıkmak için: q):");
    code = Console.ReadLine();
    var cityName = code == string.Empty || code == "q" ? "Hatalı giriş" : plates[code];

    Console.WriteLine($"{code} plakalı ilimiz: {cityName}");


} while (code != "q");


ObservableCollection<string> participants = new ObservableCollection<string>();
participants.CollectionChanged += Participants_CollectionChanged;

participants.Add("Elif Külcü");
participants.Add("Melis Babaoğlu");
participants.Add(string.Empty);
participants[2] = participants[0];
participants[0] = "Türkay Ürkmez";




void Participants_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            Console.WriteLine($"{e.NewItems[0]} katılımcısı eklendi ");
            break;
        case NotifyCollectionChangedAction.Remove:
            Console.WriteLine($"{e.OldItems[0]} katılımcısı çıkarıldı ");

            break;
        case NotifyCollectionChangedAction.Replace:
            Console.WriteLine($"{e.OldItems[0]}  katılımcısı,  {e.NewItems[0]} olarak değiştirildi");
            break;
        case NotifyCollectionChangedAction.Move:
            Console.WriteLine($"{e.OldStartingIndex}  katılımcısının indexi,  {e.NewStartingIndex} olarak değişti (taşındı) ");
            break;
        case NotifyCollectionChangedAction.Reset:
            break;
        default:
            break;
    }
}












