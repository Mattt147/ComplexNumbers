using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexNumbers;
namespace Interface
{
    public partial class Polar : Form
    {
        public Polar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Polar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComplexNumber z1;
            ComplexNumber z2;
            string p = "";
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Ошибка: заполнены не все поля");
                    return;
                }
                z1 = new ComplexNumber(double.Parse(textBox1.Text), double.Parse(textBox3.Text), p);
                z2 = new ComplexNumber(double.Parse(textBox2.Text), double.Parse(textBox4.Text), p);
            }
            catch
            {
                MessageBox.Show("Ошибка: не каждое заполненное поле является числом");
                return;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox5.Text = z1.Add(z2).ToStringPo();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                case 1:
                    textBox5.Text = z1.Dif(z2).ToStringPo();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                case 2:
                    textBox5.Text = z1.Mul(z2).ToStringPo();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                case 3:
                    if (textBox2.Text == "0")
                    {
                        textBox5.Text = "";
                        MessageBox.Show("Ошибка: деление на ноль невозможно");
                        return;
                    }
                    textBox5.Text = z1.Div(z2).ToStringPo();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                default:
                    MessageBox.Show("Вы не выбрали операцию");
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
