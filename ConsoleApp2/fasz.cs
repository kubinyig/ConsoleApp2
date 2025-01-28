using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class fasz
    {
        int multiplier = 5;
        public virtual int multiply(int geciszam)
        {
            geciszam *= multiplier;
            return geciszam;
        }
        public virtual double divide(double geciszam, double hossz)
        {
            double eredmeny;
            if (geciszam > hossz)
            {
                eredmeny = (geciszam + hossz) / hossz;
            }
            else
            {
                eredmeny = (geciszam + hossz) / geciszam;
            }
            return eredmeny;
        }
       
    }
}
