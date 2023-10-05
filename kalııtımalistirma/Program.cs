//using System;

//class Hayvanlar
//{
//    public void Yemek()
//    {
//        Console.WriteLine("yemek yer");
//    }
//    class Kopekler : Hayvanlar
//    {
//        public void Havlar()
//        {
//            Console.WriteLine("Köpekler havlar");

//        }
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {

//    }


//}

// CONSTRUCTOR

using System;

namespace ParametreliConstructor
//{
//    class ABC
//    {
//        string name;
//        int id;

//        ABC (string name, int id)
//        {
//            this.name = name;
//            this.id = id;
//        }
//        public static void Main()
//        {
//            ABC orn = new ABC("Caner", 123);
//            Console.WriteLine("Kişi adı= " + orn.name +"kişi ID="+ orn.id);

//        }
//    }
//}
{
    class Urun
    {
        string adi;
        string renk;
        int boyut;
        float fiyat;


        Urun(string adi, string renk, int boyut, float fiyat)
        {
            this.adi = adi;
            this.renk = renk;
            this.boyut = boyut;
            this.fiyat = fiyat;
        }
        public static void Main()
        {
            Urun masa = new Urun("kare masa", "siyah", 2, 100.5f);
            Console.WriteLine("Ürün adı=" + masa.adi +" " + "Ürün rengi=" + masa.renk + " " + "ürünün boyutu=" + masa.boyut + ""+ "ürünün fiyatı=" + masa.fiyat);

        }

    }
}
