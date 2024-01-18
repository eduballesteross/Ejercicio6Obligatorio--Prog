using Ejercicio6Obligatorio.Dtos;
using Ejercicio6Obligatorio.Servicios;

namespace Ejercicio6Obligatorio.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 180124
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<ClienteDto> listacliente = new List<ClienteDto>();
            
            MenuInterfaz menuI = new MenuImplementacion();
            ClienteInterfaz clienteI = new ClienteImplementacion();

            int opcion;
            bool cerrarMenu = false;

            

            while (!cerrarMenu) 
            {
                opcion = menuI.MostrarMenu();
                Console.WriteLine(opcion);

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("INFO-- Has seleccionado la opcion de cerrar el menú");
                        cerrarMenu=true;    
                        break;

                    case 1:
                        Console.WriteLine("INFO-- Has seleccionado la opcion de dar de alta a un cliente");
                        clienteI.DarAltaCliente(listacliente);
                        break;

                    case 2:
                        Console.WriteLine("INFO-- Has seleccionado la opcion de ordenar los clientes");
                        clienteI.OrdenarListaCliente(listacliente);
                        foreach (ClienteDto cliente in listacliente)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Has introducido una opcion incorrecta.");
                        break;

                }
            }
        }
    }
}
