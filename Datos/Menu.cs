using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Datos
{
    class Menu
    {
        Persona pers = new Persona();

        public void imprimir()
        {

            Console.Clear();
            Console.WriteLine(@"
                               _____________________________
                              |                             |
                              |      BIinvenido a DTS       |
                              |_____________________________|
                              | 1-    Ingresar Persona      |
                              | 2-    Listar Personas       |
                              | 3-   Actualizar Persona     |
                              | 4-     Borrar Persona       |
                              | 5-     Buscar Persona       |                     
                              | 6-         Salir            |
                              |_____________________________|");                          
        }

        public void ingP()
        {
            Console.Clear();
            Console.WriteLine(@"      
                                __________________________
                               |                          |     
                               |**************************|
                               |*****Ingresar persona*****|
                               |**************************|
                               |__________________________|");
            Console.WriteLine("Complete los siguientes datos: ");
            Console.Write("Nombre de la persona: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido de la persona: ");
            string apellido = Console.ReadLine();
            Console.Write("DNI: ");
            string dni = Console.ReadLine();
            Console.Write("Fecha de nacimiento: ");
            string fnac = Console.ReadLine();
            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();
            pers.agregar(nombre, apellido, dni, fnac, sexo);
        }
        public void listarP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                __________________________
                               |                          |     
                               |**************************|
                               |******Listar Personas*****|
                               |**************************|
                               |__________________________|");
            pers.listar();
        }
        public void buscarP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                __________________________
                               |                          |     
                               |**************************|
                               |******Buscar Persona******|
                               |**************************|
                               |__________________________|");
            Console.Write("Ingresar algun dato de la persona a buscar: ");
            string datoBusqueda = Console.ReadLine();
            pers.buscar(datoBusqueda);
        }
        public void actualizarP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                __________________________
                               |                          |     
                               |**************************|
                               |****Actulizar Personas****|
                               |**************************|
                               |__________________________|");
            Console.Write("Ingresar algun dato de la persona que desee actulizar: ");
            string datoActualizar = Console.ReadLine();
            pers.actualizar(datoActualizar);
        }
    }
}
