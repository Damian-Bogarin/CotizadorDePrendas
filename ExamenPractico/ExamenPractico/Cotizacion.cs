using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico
{
    internal class Cotizacion
    {
        private int id;
        private int vendedorId;
        private int cantidad;
        private float total;
        private string fechaHora;
        private string prendaCotizada;
        
        public int Id { get => id; set => id = value; }
        public int VendedorId { get => vendedorId; set => vendedorId = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Total { get => total; set => total = value; }
        public string FechaHora { get => fechaHora; set => fechaHora = value; }
        public string PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        

        public Cotizacion(int id, int vendedorCode, int Cantidad, float total,string fecha, bool camisa)
        {
            this.id = id;
            this.vendedorId = vendedorCode;
            this.cantidad = Cantidad;
            this.total = total;
            this.fechaHora = fecha;
            if (camisa)
            {
                prendaCotizada = "camisa";
            }
            else
            {
                prendaCotizada = "pantalon";
            }

        }

        
       
    }
}
