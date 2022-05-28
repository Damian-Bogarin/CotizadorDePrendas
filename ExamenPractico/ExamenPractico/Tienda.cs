using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico
{
    internal class Tienda
    {
        private string direccion;
        private string nombre;

        private List<Camisa> prendas = new List<Camisa>();
        private List<Pantalon> pantalones = new List<Pantalon>();
        
        public Tienda(string direction, string name)
        {
            this.direccion = direction;
            this.nombre = name;
            prendas.Add(new Camisa(100, 100, true, true, "Standard"));
            prendas.Add(new Camisa(100, 100, true, true, "Premium"));
            prendas.Add(new Camisa(100, 150, true, false, "Standard"));
            prendas.Add(new Camisa(100, 150, true, false, "Premium"));
            prendas.Add(new Camisa(100, 75, false, true, "Standard"));
            prendas.Add(new Camisa(100, 75, false, true, "Premium"));
            prendas.Add(new Camisa(100, 175, false, false, "Standard"));
            prendas.Add(new Camisa(100, 175, false, false, "Premium"));
            pantalones.Add(new Pantalon(100, 750, true, "Standard"));
            pantalones.Add(new Pantalon(100, 750, true, "Premium"));
            pantalones.Add(new Pantalon(100, 250, false, "Standard"));
            pantalones.Add(new Pantalon(100, 250, false, "Premium"));

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Camisa> Prendas { get => prendas; set => prendas = value; }
        internal List<Pantalon> Pantalones { get => pantalones; set => pantalones = value; }

        public int Buscador(bool camisa,bool chupin, bool mangaCorta, bool mao, string calidad)
        {
            int cantidad = 0;
            if (camisa) //1000
            {
                foreach (var elemento in Prendas)
                {

                    if (elemento.MangaCorta == mangaCorta) 
                    {
                        if (elemento.CuelloMao == mao) 
                        {
                            if (elemento.Calidad == calidad)
                            {
                                cantidad += elemento.Stock;
                            }

                        }
                    }

                }


            }
            else
            {
                foreach (var elemento in Pantalones)
                {

                    if (elemento.Chupin == chupin) 
                    {
                        
                        
                            if (elemento.Calidad == calidad)
                            {
                                cantidad += elemento.Stock;
                            }

                        
                    }

                }
            }
            return cantidad;

        }
        public float Valor(bool camisa,bool chupin, bool mangaCorta, bool mao, string calidad)
        {
            float value = 0f;
            if (camisa)
            {
                foreach (var elemento in Prendas)
                {

                    if (elemento.MangaCorta == mangaCorta) //500
                    {
                        if (elemento.CuelloMao == mao) //200
                         {
                            if (elemento.Calidad == calidad)
                            {
                            value = elemento.Precio;
                            }

                        }
                    }

            }
            if (mangaCorta)
            {
                value *= 0.9f;
            }
            if (mao)
            {
                value *= 1.03f;
            }
            if(calidad == "Premium")
            {
                value *= 1.3f;
            }

            }
            else
            {
                foreach (var elemento in Pantalones)
                {

                    if (elemento.Chupin == chupin) //500
                    {
                            if (elemento.Calidad == calidad)
                            {
                                value = elemento.Precio;
                            }

                        
                    }

                }

                if (chupin)
                {
                    value *= 0.88f;
                }
                if (calidad == "Premium")
                {
                    value *= 1.3f;
                }
            }
            
            return value;
        }
      
        public void Extraer(bool camisa, bool chupin, bool mangaCorta, bool mao, string calidad, int extraccion)
        {
            if (camisa) 
            {
                foreach (var elemento in Prendas)
                {

                    if (elemento.MangaCorta == mangaCorta)
                    {
                        if (elemento.CuelloMao == mao)
                        {
                            if (elemento.Calidad == calidad)
                            {
                                elemento.Stock -= extraccion;
                            }

                        }
                    }

                }


            }
            else
            {
                foreach (var elemento in Pantalones)
                {

                    if (elemento.Chupin == chupin)
                    {


                        if (elemento.Calidad == calidad)
                        {
                            elemento.Stock -= extraccion;
                        }


                    }

                }
            }
        }

    }
}
