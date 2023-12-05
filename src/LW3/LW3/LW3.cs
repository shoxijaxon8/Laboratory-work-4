using System;

namespace LW3
{
    internal class LW3
    {
        static void Main(string[] args)
        {
        }
    }
    public class ResistanceLED
    {
        public double Div(double Vcc, double Vf, double I)
        {
            if (I == 0.0D)
                throw new DivideByZeroException();

            double Ur = (Vcc - Vf) / I;
            return Ur;
        }
    }
}
