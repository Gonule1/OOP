
//Console.WriteLine("ilk sayiyi girin:");
//int sayi1= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ikinci sayiyi giriniz:");
//int sayi2= Convert.ToInt32(Console.ReadLine());

//class matematikselİslemler
//{

//    public void Toplama(int sayi1, int sayi2)
//    {
//        Console.WriteLine("Toplam=" + (sayi1 + sayi2));

//    }

//    public void Çıkarma(int sayi1, int sayi2)
//    {
//        Console.WriteLine("Fark=" + (sayi1 - sayi2));
//    }

//    public void Bölüm(int sayi1, int sayi2)
//    {
//        Console.WriteLine("Bölüm=" + (sayi1 / sayi2));
//    }
//    public void Çarpım(int sayi1, int sayi2)
//    {
//        Console.WriteLine("Çarpım=" + (sayi1 * sayi2));
//    }


//    public static void Main(string[] args)
//    {
//        Console.WriteLine(matematikselİslemler.Toplama());

//    }
//}
using classOlusturma;
matematikelIslemler islemler = new matematikelIslemler();
islemler.Topla(3, 5);
islemler.Çarp(5, 4);
islemler.Böl(7, 5);
int cikar=islemler.Cikar(5, 4);
Console.WriteLine(cikar);