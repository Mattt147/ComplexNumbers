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
            ErrorForm ef;
            ComplexNumber z1;
            ComplexNumber z2;
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
                {
                    ef = new ErrorForm("Заполнены не все поля");
                    ef.ShowDialog();
                    return;
                }
                z1 = new ComplexNumber(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                z2 = new ComplexNumber(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            }
            catch (FormatException)
            {
                ef = new ErrorForm("Не каждое заполненное поле является числом");
                ef.ShowDialog();
                return;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox5.Text = z1.Add(z2).ToString();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                case 1:
                    textBox5.Text = z1.Dif(z2).ToString();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                case 2:
                    textBox5.Text = z1.Mul(z2).ToString();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                case 3:
                    if (textBox3.Text == "0" && textBox4.Text == "0")
                    {
                        textBox5.Text = "";
                        ef = new ErrorForm("Деление на ноль невозможно");
                        ef.ShowDialog();
                        return;
                    }
                    textBox5.Text = z1.Div(z2).ToString();
                    if (textBox5.Text == string.Empty)
                        textBox5.Text = "0";
                    break;
                default:
                    ef = new ErrorForm("Вы не выбрали операцию");
                    ef.ShowDialog();
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
        FormMain  f;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
