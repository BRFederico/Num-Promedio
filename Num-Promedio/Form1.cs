namespace Num_Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            int num3 = Int32.Parse(textBox3.Text);

            double promedio = (num1 + num2 + num3);
            promedio = promedio / 3;

            MessageBox.Show("El promedio es: " + promedio);

        }
    }
}