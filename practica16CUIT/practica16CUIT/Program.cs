using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica16CUIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string masc = "20";
            string fem = "27";
            string ind = "24";
            string emp = "30";
            string dni;
            int tdni;
            int aux;

            Console.WriteLine("Tipo de DNI");
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Femenino");
            Console.WriteLine("3 - Indeterminado");
            Console.WriteLine("4 - Empresa");
            tdni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su DNI");
            dni = Console.ReadLine();

            string dnicomp = "";

            switch(tdni)
            {
                case 1:
                    dnicomp = masc + dni;
                    break;
                case 2:
                    dnicomp = fem + dni;
                    break;
                case 3:
                    dnicomp = ind + dni;
                    break;
                case 4:
                    dnicomp = emp + dni;
                    break;
            }

            aux = int.Parse(dnicomp[0].ToString()) * 5;
            aux = aux + int.Parse(dnicomp[1].ToString()) * 4;

            aux = aux + int.Parse(dnicomp[2].ToString()) * 3;
            aux = aux + int.Parse(dnicomp[3].ToString()) * 2;
            aux = aux + int.Parse(dnicomp[4].ToString()) * 7;
            aux = aux + int.Parse(dnicomp[5].ToString()) * 6;
            aux = aux + int.Parse(dnicomp[6].ToString()) * 5;
            aux = aux + int.Parse(dnicomp[7].ToString()) * 4;
            aux = aux + int.Parse(dnicomp[8].ToString()) * 3;
            aux = aux + int.Parse(dnicomp[9].ToString()) * 2;

            int aux2 = aux;
            aux = aux / 11;
            aux2 = aux2 - (aux * 11);
            aux2 = 11 - aux2;

            Console.WriteLine(aux2);
            Console.ReadKey();

        } 
    }
}
