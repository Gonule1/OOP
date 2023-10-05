using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class ProductService : IProductService
    {
        public void Add()
        {
            Console.WriteLine("ürün eklendi");        }

        public void GetList()
        {
            Console.WriteLine("ürünler listelendi");
        }

        public void Remove()
        {
            Console.WriteLine("ürünler silindi");
        }
    }
}
