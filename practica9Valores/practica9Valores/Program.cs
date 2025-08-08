using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num;
            num = 30;

            cambiar(num);
            Console.WriteLine($"El valor luego de la llamada es: {num}");

            Console.ReadKey();

            // Para modificar el valor dentro de los parametros se utiliza la ref (referencia)

            int v1, v2;
            v1 = 5;
            v2 = 10;

            Console.WriteLine($"Antes de la llamada: \nValor 1 = {v1} \nValor 2 = {v2}");
            Console.ReadKey();

            cambiar3(ref v1, ref v2);

            Console.WriteLine($"Despues de la llamada: \nValor 1 = {v1} \nValor 2 = {v2}");
            Console.ReadKey();
            

            int[] valores = new int[5];
            valores[0] = 15;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 45;
            valores[4] = 65;

            lista(valores);
            Console.ReadKey();
            */

            int[] valoresB = new int[10];

            for (int i = 0; i < valoresB.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese el valor N° {i+1}: ");
                valoresB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lista ordenada:");
            metBurj(valoresB);

            for (int i = 0;i < valoresB.Length;i++)
            {
                Console.WriteLine($"Dato: {i} Valor: {valoresB[i]}");
            }
            Console.ReadKey();

        }

        static void cambiar (int num)
        {
            num = 11;
            Console.WriteLine($"El valor dentro de la llamada es: {num}");
        }

        static void cambiar3(ref int v1, ref int v2)
        {
            int aux = v1;
            v1 = v2;
            v2 = aux;
        }

        static void lista(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Pos: {i} Dato: {valores[i]}");
            }
        }

        static void metBurj(int[] valoresB)
        {
            for (int i = 0;i < valoresB.Length - 1;i++)
            {
                for (int j = 0; i < valoresB.Length - 1 -i;j++)
                {
                    if (valoresB[j] > valoresB[j + 1])
                    {
                        int aux = valoresB[j];
                        valoresB[j] = valoresB[j + 1];
                        valoresB[j + 1] = aux;
                    }
                }
            }
        }
    }
}
