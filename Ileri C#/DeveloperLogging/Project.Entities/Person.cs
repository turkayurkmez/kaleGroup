using Project.Core;

namespace Project.Entities
{

    [DeveloperInfo("Türkay Ürkmez",CreatedDate = "29.6.2002", Description = "Bu model, veritabanında temsil edilecek Person'a karşılık gelir.")]
    public class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DeveloperInfo("Türkay Ürkmez",Description = "Maaş bilgisi eklendi")]
        [DeveloperInfo("Elif Külcü", Description = "Salary özelliği decimal olarak güncellendi")]
        public decimal Salary { get; set; }
    }
}