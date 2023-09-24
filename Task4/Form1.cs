namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxnumber1.Text = "������� �����";
            TextBoxnumber2.Text = "������� �����";
            button1.Text = "���������";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void TextBoxnumber1_Click(object sender, EventArgs e)
        {
            if (TextBoxnumber1.Text == "������� �����")
            {
                TextBoxnumber1.Text = "";
            }
        }
        private void TextBoxnumber2_Click(object sender, EventArgs e)
        {
            if (TextBoxnumber2.Text == "������� �����")
            {
                TextBoxnumber2.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBoxnumber1.Text);
            int number2 = int.Parse(TextBoxnumber2.Text);
            int result = 0;
            if (radioButton1.Checked)
            {
                if (number1 != 0 && number2 != 0)
                {
                    result = number1 % number2;
                }
                else
                {
                    MessageBox.Show("������� �� 0 ����������");
                }
            }
            else if (radioButton2.Checked)
            {
                result = (int)Math.Pow(number1, number2);
            }
            else if (radioButton3.Checked)
            {
                result = int.Parse(number1.ToString() + number2.ToString());

            }
            else if (radioButton4.Checked)
            {
                if (number1 != 0 && number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    MessageBox.Show("������� �� 0 ����������");
                }
            }
            Textboxresult.Text = result.ToString();
        }

    }
}