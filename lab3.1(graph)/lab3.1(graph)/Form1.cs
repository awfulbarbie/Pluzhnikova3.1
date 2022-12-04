namespace lab3._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            static double min(double a, double b)
            {
                return (a < b) ? a : b;
            }
            static double[] f(double x1, double x2, double y1, double y2, double x3, double y3)
            {
                double otr1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                double otr2 = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                double otr3 = Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));

                double result = min(min(otr1, otr2), otr3);

                if (result == otr1)
                {
                    return new double[] { x1, y1, x2, y2 };
                }
                else if (result == otr2)
                {
                    return new double[] { x1, y1, x3, y3 };
                }
                else if (result == otr3)
                {
                    return new double[] { x2, y2, x3, y3 };
                }
                else
                {
                    return new double[] { 0 };
                }
            }

            {
                double x1 = Convert.ToDouble(textBox1.Text);
                double y1 = Convert.ToDouble(textBox2.Text);
                double x2 = Convert.ToDouble(textBox3.Text);
                double y2 = Convert.ToDouble(textBox4.Text);
                double x3 = Convert.ToDouble(textBox5.Text);
                double y3 = Convert.ToDouble(textBox6.Text);

                textBox7.Text = ("ƒве точки, рассто€ние между которыми минимально: ");
                double[] array = new double[4];
                array = f(x1, x2, y1, y2, x3, y3);
                foreach (double x in array)
                {
                    textBox7.Text += ($"{x} ");
                }
            }
        }
    }
}