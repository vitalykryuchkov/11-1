namespace _11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double num = trackBar1.Value;
            double right_window = num * (num + 1) * (2 * num + 1) * (3 * Math.Pow(num, 2) + 3 * num - 1) / 30;
            textBox2.Text = right_window.ToString();
            double sum = 0.0;
            for (int i = 0; i < num; i++)
            {
                sum += Math.Pow(i, 4);
            }
            double result = sum + Math.Pow(num, 4);
            textBox1.Text = result.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            label1.Text = String.Format($"Текущее значение n: {trackBar1.Value} ");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}