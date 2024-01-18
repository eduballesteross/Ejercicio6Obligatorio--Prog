using Ejercicio6Obligatorio.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    /// <summary>
    /// Implementacion a los métodos de ClienteInterfaz
    /// ebp - 180124
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void DarAltaCliente(List<ClienteDto> listaClientes)
        {
           ClienteDto cliente = crearNuevoCliente();
            listaClientes.Add(cliente);

        }

        private ClienteDto crearNuevoCliente() 
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca su ID.");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca su nombre.");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca sus apellidos.");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su edad");
            nuevoCliente.EdadCliente = Convert.ToInt32(Console.ReadLine());   

            nuevoCliente.NombreCompleto = nuevoCliente.NombreCliente + " " + nuevoCliente.ApellidosCliente;

            return nuevoCliente;    
        }

        public void OrdenarListaCliente(List<ClienteDto> listaCliente)
        {
            if (listaCliente.Count >= 3)
            {
                foreach (ClienteDto cliente in listaCliente)
                {
                    Console.WriteLine(cliente.ToString());
                }
                int n = listaCliente.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        
                        if (listaCliente[j].EdadCliente < listaCliente[j + 1].EdadCliente)
                        {
                            ClienteDto aux = listaCliente[j];
                            listaCliente[j] = listaCliente[j + 1];
                            listaCliente[j + 1] = aux;
                        }
                    }
                }

                Console.WriteLine("[INFO] Lista de clientes ordenada por edad de forma descendente.");
            }
            else
            {
                Console.WriteLine("[INFO] La lista debe tener al menos 2 clientes para ordenar.");
            }
        }
    }
}
