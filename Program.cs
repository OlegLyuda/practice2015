using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static double function(double x)
        {
            double f;
            f = x * x +2;
            return f;
        }
        static void Main(string[] args)
        {
            double a = 0;
            double b = 2;
            double e = 0.1;
            double xk ,lk,fk,yk,zk,fyk,fzk;
            //Shag 3:
            xk = (a + b) / 2;
            //Console.WriteLine(xk);
            lk = Math.Abs(b - a);
            //fk =function(xk);
            Shag4:
            //xk = (a + b) / 2;
            fk = function(xk);
            yk = a + lk / 4;
            zk = b - lk / 4;
            fyk = function(yk);
            fzk = function(zk);
            //Shag 5:
            if (fyk < fk)
            {
                b = xk;
                xk = yk;
                goto Shag7;
            }
            else
            {
                goto Shag6;
            }
            Shag6:
            if (fzk < fk)
            {
                a = xk;
                xk = zk;
                goto Shag7;
            }
            else
            {
                a = yk;
                b = zk;
                goto Shag7;
            }
        Shag7:
            lk = Math.Abs(b - a);
            if (lk < e)
            {
                goto Finish;
            }
            else
            {
                goto Shag4;
            }

    Finish:
        Console.WriteLine("xk=" + xk);

        }
       
    }
}
