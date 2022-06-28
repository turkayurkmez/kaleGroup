public class Program
{
    public static void Main(string[] args)
    {
        /*
         * 4 Şekil: Kare, Daire, Üçgen, Dikdörtgen
         * Bazıları sadece bir parametre ile hesaplanabiliyor diğerleri ise iki
         */

        var kare = opsiyonelAlanHesapla(5);
        Console.WriteLine($"karenin alanı:{kare}");

        var daire = opsiyonelAlanHesapla(5, sekil: "Daire");
        Console.WriteLine($"daire: {daire}");

        var ucgen = opsiyonelAlanHesapla(12, 3, sekil: "Üçgen");
        Console.WriteLine($"üçgen: {ucgen}");



    }

    static double alanHesapla(double birimUzunluk, string sekil)
    {
        switch (sekil)
        {
            case "Kare":
                return Math.Pow(birimUzunluk, 2);
            case "Daire":
                return Math.PI * Math.Pow(birimUzunluk, 2);
            default:
                throw new ArgumentException(sekil);

        }
    }

    static double alanHesapla(double en, double boy, string sekil)
    {
        switch (sekil)
        {
            case "Dikdörtgen":
                return en * boy;
            case "Üçgen":
                return (en * boy) / 2;
            default:
                throw new ArgumentException(sekil);

        }
    }

    static double opsiyonelAlanHesapla(double birim1, double birim2=1, string sekil = "Kare")
    {
        switch (sekil)
        {
            case "Kare":
                return Math.Pow(birim1, 2);
            case "Daire":
                return Math.PI * Math.Pow(birim1, 2);
            case "Dikdörtgen":
                return birim1 * birim2;
            case "Üçgen":
                return (birim2 * birim1) / 2;

            default:
                throw new ArgumentException(sekil);
            
        }
    }








}