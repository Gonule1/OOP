using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classOlusturma
{
  public class matematikelIslemler
    {
        public void Topla(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);

        }
        public void Çarp(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1*sayi2);
        }
        public void Böl(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1/sayi2);
        }
        public int Cikar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
