using System.Drawing.Text;

namespace Quiz05___Methods
{
    public partial class Form1 : Form
    { // Create one Random object at form level
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            int number = random.Next(1, 10); // 1 to 10
            outputLabel.Text = number.ToString();

        }

        private void productNumber()

        {
            int num1 = 45;
            int num2 = 50;
            int product = num1 * num2;

            outputLabel.Text = product.ToString();





        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            productNumber();
        }
    }
}

