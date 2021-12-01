using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace up2
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "qqw";
            string password = "123";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                Form1 f3 = new Form1(true);
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка при вводе даных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1(false);
            f3.ShowDialog();
        }

        private void intel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
