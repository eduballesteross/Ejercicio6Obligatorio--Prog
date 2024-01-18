using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
      
        /// <summary>
        /// Implementacion a los métodos de MenuInterfaz
        /// ebp - 180124
        /// </summary>
        
        public int MostrarMenu()
        {
            int opcion;

            Console.WriteLine("#########################");
            Console.WriteLine("#0- Cerrar menú         #");
            Console.WriteLine("#1- Dar de alta cliente #");
            Console.WriteLine("#2- Ordenar Clientes    #");
            Console.WriteLine("#########################");

            opcion = Console.ReadKey(true).KeyChar - ('0');
            
            return opcion;  
         
        }
    }
}
