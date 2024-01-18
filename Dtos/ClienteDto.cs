using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Dtos
{
    /// <summary>
    /// Clase que contiene el ente cliente
    /// 180124 - ebp
    /// </summary>
    internal class ClienteDto
    {
        //ATRIBUTOS

        long idCliente;

        string nombreCliente = "aaaaaaaa";

        string apellidosCliente= "aaaaaaaa";

        string nombreCompleto = "aaaaaaaa";

        int edadCliente =999;


        //GETTERS & SETTERS
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompleto, int edadCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompleto = nombreCliente+" "+apellidosCliente;
            this.edadCliente = edadCliente;
        }

        public ClienteDto() { } 

        /// <summary>
        ///Método para que el usuario pueda escribir por pantalla los atributos del objeto 
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            string clienteString =
                "Nombre y apellidos: "+this.nombreCompleto + " | " +
                "Edad: " + this.edadCliente;

            return clienteString;
        }
    }
}
