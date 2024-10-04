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
            double[,] arr = new double[500, 2];
             this.graphic.Series[0].Points.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random value = new Random();
                    arr[i, j] = value.NextDouble();
                }

            this.graphic.Series[0].Points.Clear();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                this.richTextBox1.Text += "x1= " + arr[i, 0] +
                    " x2= " + arr[i, 1] + " "
                    + Neuron(arr[i, 0], arr[i, 1]) + " \n";

                this.graphic.Series[0].Points.AddXY(arr[i, 0], arr[i, 1]);
            }
        }
        private string Neuron(double x1, double x2)
        {
            return (x1 + x2 - 0.5) > 0 ? "klass A" : "klass B";
        }
    }
}