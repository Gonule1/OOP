using CopyCons;
using System;
namespace CopyCons
{
    class XYZ
    {
        private string _month;
        private int _year;

        public XYZ(XYZ s)
        {
            _month = s._month;
            _year = s._year;
        }
        public XYZ(string _month, int _year)
        {
            this._month = _month;
            this._year = _year;
        }




        public string Yazilanlar
        {
            get
            {
                return "Ay:" + _month.ToString() + "\nYıl" + _year.ToString();

            }
        }
        public static void Main()
        {
            XYZ nesne1 = new XYZ("ocak", 2024);
            XYZ nesne2 = new XYZ(nesne1);
            Console.WriteLine(nesne2.Yazilanlar);

        }


    }
}