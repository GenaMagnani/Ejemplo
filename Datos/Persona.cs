using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace Datos
{
    class Persona
    {
        public string ruta = "D:\\dtaCS\\lista.txt";

        public void agregar(string nombre, string apellido, string dni, string fnac, string sexo)
        {
            Console.Clear();
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.Write($"{nombre},");
                sw.Write($"{apellido},");
                sw.Write($"{dni},");
                sw.Write($"{fnac},");
                sw.Write($"{sexo},");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: " + e.Message);
            }
            finally
            {
            }
        }
        public void listar()
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach(var linea in lineas)
                {
                    var valores = linea.Split(',');
                    Console.WriteLine("* ----------- * ----------- * ----------- * ");
                    Console.WriteLine($"Nombre de la persona: {valores[0]}\n" +
                        $"Apellido: {valores[1]}\n" +
                        $"DNI: {valores[2]}\n" +
                        $"Fecha de nacimiento: {valores[3]}\n" +
                        $"Sexo: {valores[4]}\n");
                    Console.WriteLine("* ----------- * ----------- * ----------- * ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: " + e.Message);
            }
            finally
            {
            }
            Console.Write("Fin de la lista");
            Console.ReadKey();
        }
        public bool buscar(string datoBusqueda)
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                if (linea.Contains(datoBusqueda))
                {
                    return true;
                }
            }
            return false;
        }
        public void actualizar(string datoActualizar)
        {
            if (buscar(datoActualizar))
            {
                Console.WriteLine("Persona encontrada");
                Console.ReadKey();
            } else {
                Console.WriteLine("Persona no encontrada");
                Console.ReadKey();
            }
        }
    }
}
