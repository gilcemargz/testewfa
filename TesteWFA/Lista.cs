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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                listBox1.Items.Insert(i, i);
            }

            int i2 = 0;

            listBox1.Items.Clear();


            while (i2<10)
            {
                listBox1.Items.Add(i2);

                i2++;

            }

        }
    }
}
