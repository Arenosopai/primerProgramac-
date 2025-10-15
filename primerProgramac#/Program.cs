using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerProgramac_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("ingrese un numero: ");
            //int numero = int.Parse(Console.ReadLine()); /*readline = para leer la entrada del usuario */
            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("el numero que usted ingreso es: " + numero + "es par.");
            //}
            //else {
            //    Console.WriteLine($"el numero que usted ingreso es: {numero} es impar");
            //    }


            //ejercicio N.2
            //Console.WriteLine("ingrese la nota #1: ");
            //float nota1 = int.Parse(Console.ReadLine());
            //double PromedioN1 = nota1 * 0.20;
            //Console.WriteLine("ingrese la nota #2: ");
            //float nota2 = int.Parse(Console.ReadLine());
            //double PromedioN2 = nota2 * 0.30;
            //Console.WriteLine("ingrese la nota #3: ");
            //float nota3 = int.Parse(Console.ReadLine());
            //double PromedioN3 = nota3 * 0.50;
            //double promedioTotal = (PromedioN1 + PromedioN2 + PromedioN3);
            //Console.WriteLine($"promedio de 3 notas: {promedioTotal}");
            //if (promedioTotal > 3) {
            //     Console.WriteLine("aprovo");;
            //        }
            //else { Console.WriteLine("no aprovado"); }

            //ejercicioN3
            Console.WriteLine("ingrese el valor a pagar : ");
            int valoraPagar = int.Parse(Console.ReadLine());
            if (valoraPagar >= 100000)
            {
                double descuento = valoraPagar - (valoraPagar * 0.20);
                Console.WriteLine($"debes pagar el valor con el descuento de 20% aplicado : Total:{valoraPagar} valor con descuento: {descuento}");
            }
            else { Console.WriteLine($"debes pagar el total del producto, no aplican descuentos: total: {valoraPagar}"); }














            }
    }
}
