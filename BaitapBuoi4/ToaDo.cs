
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi4
{
    class ToaDo
    {
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private float _x,_y;

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public ToaDo()
        { 
        }
        public ToaDo(string ten, float x, float y)
        {
            this._ten = ten;
            this._x = x;
            this._y = y;
        }

        public override string ToString()
        {
            return "Ten:" +_ten + "X:" +_x + "Y:" + _y;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ten toa do:");
            _ten = Console.ReadLine();
            Console.WriteLine("Nhap toa do x:");
            _x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y:");
            _y = float.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Ten toa do: {0}\n Toa do x la: {1}\n Toa do y la: {2}", _ten, _x, _y);
        }
    }
}
