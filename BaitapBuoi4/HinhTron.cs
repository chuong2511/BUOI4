using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi4
{
    class HinhTron
    {
        private ToaDo _tam;

        public ToaDo Tam
        {
            get { return _tam; }
            set { _tam = value; }
        }
        private double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        public HinhTron()
        {
        }

        public HinhTron(ToaDo tam, double banKinh)
        {
            this._banKinh = banKinh;
            this._tam = tam;
        }

        public double tinhChuVi()
        {
            return _banKinh * 2 * 3.14;
        }

        public double tinhDienTich()
        {
            return _banKinh * _banKinh * 3.14;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap tam hinh tron:");
            _tam = (Console.ReadLine());
        }
    }
}
