using System;
using System.Windows.Forms;

namespace UniformMovementAroundTheCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            float R, T, V;
            R = float.Parse(textBoxRadius.Text);
            T = float.Parse(textBoxRPM.Text);

            if (T == 0.0D)
                throw new DivideByZeroException();

            V = (float)((2 * Math.PI * R) / T);
            textBoxV.Text = Convert.ToString(Math.Round(V, 2));
        }
    }
}
