using ComplexNumbers;
namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplexNumber z1;
            ComplexNumber z2;
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Ошибка: заполнены не все поля");
                    return; 
                }
                z1 = new ComplexNumber(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                z2 = new ComplexNumber(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: не каждое заполненное поле является числом");
                return;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox5.Text = z1.Add(z2).ToString();
                    break;
                case 1:
                    textBox5.Text = z1.Dif(z2).ToString();
                    break;
                case 2:
                    textBox5.Text = z1.Mul(z2).ToString();
                    break;
                case 3:
                    textBox5.Text = z1.Div(z2).ToString();
                    break;
                default:
                    MessageBox.Show("Вы не выбрали операцию");
                    return;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
    }
}
