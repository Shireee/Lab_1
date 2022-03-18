using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_1
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        //addition 
        public void Add(Complex z)
        {
            Real += z.Real;
            Imag += z.Imag;
        }

        // subtraction 
        
        public void Subtract(Complex z)
        {
            Real -= z.Real;
            Imag -= z.Imag; 
        }

        // Multiplication 
        public void Multiplicate(Complex z) {
            Real = Real* z.Real - Imag* z.Real;
            Imag = Real * z.Imag + Imag * z.Real;
        }

        // Division 
        public void Divide(Complex z) {
            Real = (Real * z.Real + Imag + z.Imag) / ((z.Real * z.Real) + (z.Imag * z.Imag));
            Imag = (Imag*z.Real - Real*z.Imag)/ ((z.Real * z.Real) + (z.Imag * z.Imag));
        }
    }
}
