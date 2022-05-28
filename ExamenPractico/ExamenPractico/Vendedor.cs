using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico
{
    internal class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigo;


        public Vendedor(string name, string lastName, int code)
        {
            this.nombre = name;
            this.apellido = lastName;
            this.codigo = code;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
