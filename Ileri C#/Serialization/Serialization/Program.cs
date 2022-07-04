
using Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

ProductList productList = new ProductList();
productList.Add(new Product(id: 1, price: 150) { Name = new NameDetails { English = "Laptop", Turkish = "Dizüstü" }, Description = "Desc x", Version = "1.0" });
productList.Add(new Product(id: 2, price: 150) { Name = new NameDetails { English = "T-Shirt", Turkish = "Tişört" }, Description = "Desc y", Version = "1.1" });
productList.Add(new Product(id: 3, price: 150) { Name = new NameDetails { English = "Table", Turkish = "Masa" }, Description = "Desc z", Version = "2.0" });

var jsonPath = "../../../products.json";
serializeToJson(productList, jsonPath);
var deserializeFromJson = deserializeFromJsonFile(jsonPath);
deserializeFromJson.Add(new Product(id: 4, price: 150) { Name = new NameDetails { English = "Clock", Turkish = "Saat" } });


var xmlPath = "../../../products.xml";
serializeToXml(xmlPath, productList);

var xmlSerial = deserializeFromXml(xmlPath);


var binPath = "../../../products.bin";
serializeToBinary(binPath, productList);

Console.WriteLine("İşlem tamamlandı");


void serializeToJson(ProductList productList, string path)
{
    Console.WriteLine("JSON formatına serileştiriliyor.");
    var jsonResult = JsonSerializer.Serialize(productList);
    File.WriteAllText(path, jsonResult);

}

ProductList deserializeFromJsonFile(string path)
{
    Console.WriteLine("Json dosyasından deserialize ediliyor");
    var jsonData = File.ReadAllText(path);
    var result = JsonSerializer.Deserialize<ProductList>(jsonData);
    return result;
}


void serializeToXml(string path, ProductList productList)
{
    Console.WriteLine("XML formatına serileştiriliyor.");
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductList));
    using FileStream fileStream = new FileStream(path, FileMode.Create);
    xmlSerializer.Serialize(fileStream, productList);  


}

ProductList deserializeFromXml(string path)
{
    Console.WriteLine("XML dosyasından okunuyor");
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductList));
    using FileStream fileStream = new FileStream(path, FileMode.Open);
    return (ProductList) xmlSerializer.Deserialize(fileStream);

}

void serializeToBinary(string path, ProductList productList)
{
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    using FileStream stream = new FileStream(path, FileMode.Create);
    binaryFormatter.Serialize(stream, productList);
    Console.WriteLine(path+ " oluşturuldu" );

}

