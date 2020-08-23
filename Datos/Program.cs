using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int opc = 0;
            while (opc != 6)
            {
                menu.imprimir();
                Console.Write("\nIngresar una opcion: ");
                opc = int.Parse(Console.ReadLine());
                while (!(opc >= 1 && opc <= 6))
                {
                    Console.Clear();
                    Console.Write("La opcion ingresada no existe, vuelva a ingresar: ");
                    opc = int.Parse(Console.ReadLine());
                }
                switch (opc)
                {
                    case 1:
                        {
                            menu.ingP();
                            break;
                        }
                    case 2:
                        {
                            menu.listarP();
                            break;
                        }
                    case 3:
                        {
                            menu.actualizarP();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("opc");
                            break;
                        }
                    case 5:
                        {
                            menu.buscarP();
                            break;
                        }
                }
            }
        }
    }
}
