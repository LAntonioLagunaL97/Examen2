using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Seleccion =this.comboBox1.Text.ToString();

            if (Seleccion == "Triangulo")
            {
                string C = this.textBox2.Text.ToString();
                string D = this.textBox1.Text.ToString();
                
                if ((C   !="")&&(D !=""))
                {
                    double B = Convert.ToDouble(D);
                    double A = Convert.ToDouble(C);
                    Triangulo T1 = new Triangulo(B, A);
                    this.richTextBox1.Text = Convert.ToString( T1.Area());
                }
                else {

                    this.richTextBox1.Text = "Falta un parametro";
                }
                

                
            }
            else if (Seleccion=="Cuadrado")
            {
                double L= Convert.ToDouble(this.textBox1.Text.ToString());
                Cuadrado C1 = new Cuadrado(L);

                this.richTextBox1.Text = Convert.ToString(C1.Area());

            }
            else if (Seleccion == "Circulo")
            {
                double R = Convert.ToDouble(this.textBox1.Text.ToString());
                Circulo Ci1 = new Circulo(R);

                this.richTextBox1.Text = Convert.ToString(Ci1.Area());

            }
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }
    }
}
