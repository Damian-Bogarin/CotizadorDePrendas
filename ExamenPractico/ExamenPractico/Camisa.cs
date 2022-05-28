using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico
{
    internal class Camisa : Prenda
    {
        private bool mangaCorta;
        private bool cuelloMao;

        public Camisa(int price,int quantity,bool Short, bool Mao,string quality )
        {
            precio = price;
            calidad = quality;
            stock = quantity;
            mangaCorta = Short;
            cuelloMao = Mao;

        }

        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }
        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }

        public string Calidad { get => calidad; set => calidad = value; }
        
        public int Stock { get => stock; set => stock = value; }

        public int Precio { get => precio; set => precio = value; }
    }
}
