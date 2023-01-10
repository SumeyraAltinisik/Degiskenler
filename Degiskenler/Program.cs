namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sehir, ilce;
            //sehir = "İstanbul";
            //ilce = "Beykoz";
            //Console.Write(sehir + "-" + ilce);
            //Console.Read();

            //int sayi;
            //sayi = 24;
            //Console.Write(sayi);

            //int sayi1, sayi2, toplam;
            //sayi1 = 12;
            //sayi2 = 25;
            //toplam = sayi1 + sayi2;
            //Console.Write(toplam);

            int sayi1, sayi2, toplam, fark, carpim, bolum;
            Console.WriteLine("Bir sayı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birinci sayı:" + sayi1);
            Console.WriteLine("Bir sayı daha giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayı:" + sayi2);
            
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            fark = sayi1 - sayi2;
            Console.WriteLine(fark);
            carpim = sayi1 * sayi2;
            Console.WriteLine(carpim);
            bolum = sayi1 / sayi2;
            Console.WriteLine(bolum);
            Console.Read();

        }
    }
}