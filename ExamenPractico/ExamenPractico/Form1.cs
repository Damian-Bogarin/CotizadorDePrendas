using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPractico
{
    public partial class Form1 : Form
    {
        private Tienda comercio;  
        private Vendedor vendedor; 
        private bool camisa = false;
        private bool mangaCorta = false;
        private bool cuelloMao = false;
        private bool chupin = false;
        private string calidad;
        private float cantidad;

        private int id;
        private List<Cotizacion> cotizacions = new List<Cotizacion>();
        public Form1()
        {
            InitializeComponent();

            comercio = new Tienda("Calle siempreViva", "Gucci Store");
            vendedor  = new Vendedor("Jorge", "Curioso", 286);
            calidad = "Standard";
            id = 0;
            radioButton3.Checked = true;
            radioButton1.Checked = true;
            cantidad = (float)numericUpDown1.Value;

        }



        

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = comercio.Nombre;
            label3.Text = comercio.Direccion;
            label4.Text = $"{vendedor.Nombre} {vendedor.Apellido}";
            label6.Text = vendedor.Codigo.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cuelloMao = true;
                Cantidad();
            }
            else
            {
                cuelloMao = false;
                Cantidad();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                chupin = true;
            }
            else
            {
                chupin = false;
            }
            Cantidad();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                camisa = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                Cantidad();

            }
            else
            {
                camisa = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                Cantidad();
            }

            if (radioButton2.Checked)
            {

                checkBox3.Visible = true;
                Cantidad();
            }
            else
            {
                checkBox3.Visible = false;
                Cantidad();
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            Cantidad();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mangaCorta = true;
                Cantidad();
            }
            else
            {
                mangaCorta = false;
                Cantidad();
            }
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                calidad = "Standard";
                Cantidad();
            }
            else
            {
                calidad = "Premium";
                Cantidad();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                calidad = "Premium";
                Cantidad();
            }
            else
            {
                calidad = "Standard";
                Cantidad();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cantidad = (float)numericUpDown1.Value;
            Cantidad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int disponible = Convert.ToInt32(label8.Text);
            int cantidad = (int)numericUpDown1.Value;
            if (cantidad > disponible || cantidad == 0)
            {
                MessageBox.Show("Error! la cantidad no puede ser 0 ni puede ser mayor a lo que hay en stock");
            }
            else
            {

                float precioFinal = comercio.Valor(camisa, chupin, mangaCorta, cuelloMao, calidad) * cantidad;
                string date = DateTime.Now.ToString();
                cotizacions.Add(new Cotizacion(id, vendedor.Codigo, cantidad, precioFinal, date, camisa));

                comercio.Extraer(camisa, chupin, mangaCorta, cuelloMao, calidad, cantidad);
                Cantidad();

                id++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(cotizacions.Count == 0)
            {
                MessageBox.Show("Este vendedor no ha realizado ninguna cotizacion todavia.");
            }
            else
            {
                dataGridView1.DataSource = cotizacions;
            }
            
        }
        private void Cantidad()
        {
            float precioFinal = comercio.Valor(camisa,chupin, mangaCorta, cuelloMao, calidad) * cantidad;
            
                label8.Text = comercio.Buscador(camisa,chupin ,mangaCorta,cuelloMao,calidad).ToString();
                label11.Text = comercio.Valor(camisa,chupin, mangaCorta, cuelloMao, calidad).ToString();
                label13.Text = precioFinal.ToString();
        }
    }
}
