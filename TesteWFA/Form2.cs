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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Double area, altura, resultado;

            altura = Convert.ToDouble( alturaValor.Text);
            area = Double.Parse(baseValor.Text);

            resultado = calculaTriangulo(area, altura);

            resultadoValor.Text = resultado.ToString() ;

        }

        private Double calculaTriangulo ( Double area, Double altura )
        {
            return (area*altura)/2;
        }
    }
}
