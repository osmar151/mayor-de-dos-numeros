using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor
{
    class Program
    {
        static mayores ma = new mayores();



        static void Main(string[] args)

        {

            int v1 = 120, v2 = 151, v3 = 755, v4 = 1200, v5 = 20050, v6 = 255, v7 = 3438, v8 = 352, v9 = 326, v10 = 3565;

            int resultado = 0;



            resultado = ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(ma.MayorAB(v1, v2), ma.MayorAB(v3, v4)), ma.MayorAB(v5, v6)), ma.MayorAB(v7, v8)), ma.MayorAB(v9, v10));



            Console.Write("el mayor es; " + resultado);



            Console.ReadKey();

        }

    }

} 

