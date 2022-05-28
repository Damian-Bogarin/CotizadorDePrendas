using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico
{
    internal class Pantalon : Prenda
    {
        private bool chupin;
        public Pantalon(int price, int quantity, bool Chupin, string quality)
        {
            precio = price;
            calidad = quality;
            stock = quantity;
            chupin = Chupin;
        }

        public string Calidad { get => calidad; set => calidad = value; }

         public int Stock { get => stock; set => stock = value; }

        public int Precio { get => precio; set => precio = value; }
        public bool Chupin { get => chupin; set => chupin = value; }

    }

   
}
