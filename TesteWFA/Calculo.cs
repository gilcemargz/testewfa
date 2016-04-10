using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteWFA
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            try
            {

            
            switch ( comboBox1.SelectedIndex )
            {
                case 0: 
                    valor1 = Convert.ToDouble(textBox1.Text);
                    valor2 = Convert.ToDouble(textBox2.Text);

                    MessageBox.Show("Soma=" + (valor1 + valor2));
                    break;
                case 1:
                    valor1 = Convert.ToDouble(textBox1.Text);
                    valor2 = Convert.ToDouble(textBox2.Text);

                    MessageBox.Show("Soma=" + (valor1 - valor2));
                    break;

                case 2:
                    valor1 = Convert.ToDouble(textBox1.Text);
                    valor2 = Convert.ToDouble(textBox2.Text);

                    MessageBox.Show("Soma=" + (valor1 * valor2));
                    break;

                case 3:
                    valor1 = Convert.ToDouble(textBox1.Text);
                    valor2 = Convert.ToDouble(textBox2.Text);

                    MessageBox.Show("Soma=" + (valor1 / valor2));
                    break;


                default:
                    break;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta informar");
                
            }

        }
    }
}
