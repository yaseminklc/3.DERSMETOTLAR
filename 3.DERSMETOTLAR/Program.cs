using _3.DERSMETOTLAR;

internal class Program
{
    private static void Main(string[] args)
    {
        string productAdi = "Elma";
        double Fiyati = 15;
        string Aciklama = "Amasya elması";


        string[] meyveler = new string[] { };     

        Product product1 = new Product();
        product1.Adi = "Elma";
        product1.Fiyati = 15;
        product1.Aciklama = "Amasaya elması";

        Product product2 = new Product();
        product2.Adi = "Karpuz";
        product2.Fiyati = 80;
        product2.Aciklama = "Diyarbakır karpuzu";

        Product[] products = new Product[] { product1, product2 };

        foreach (Product product in products)
        {
            Console.WriteLine(product.Adi);
            Console.WriteLine(product.Fiyati);
            Console.WriteLine(product.Aciklama);
            Console.WriteLine("......................");
        }
         

        Console.WriteLine("...............Metodlar....................");
        //intance

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(product1);
        sepetManager.Ekle(product2);

        sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
        sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
        sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);


    }
} 