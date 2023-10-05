using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// İNTERFACELER BİR SOYUT CLASSTIR
// İNTERFACELER NEWLENEMEZ
// İNTERFACELER BİRER ANLAŞMADIR

namespace Kalitim
{
    internal interface IProductService
    {
        void Add();
        void Remove();
        void GetList();

    }
}
