using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create two's measurement array where values are randoms
            double[,] arr = new double[500, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random value = new Random();
                    arr[i, j] = value.NextDouble();
                }

            //clear our chart field (field where graphics are drawn)
            this.graphic.Series[0].Points.Clear();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                this.richTextBox1.Text += "x1= " + arr[i, 0] +
                    " x2= " + arr[i, 1] + " "
                    + (this.radioButtonOR.Checked ? NeuronOR(arr[i, 0], arr[i, 1]) :  NeuronAND(arr[i, 0], arr[i, 1]))
                    + " \n";

                this.graphic.Series[0].Points.AddXY(arr[i, 0], arr[i, 1]);
            }
        }
        private string NeuronOR(double x1, double x2)
        {
            return (x1 + x2 - 0.5) > 0 ? "klass A" : "klass B";
        }
        private string NeuronAND(double x1, double x2)
        {
            return (x1 + x2 - 1.5) > 0 ? "klass A" : "klass B";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}