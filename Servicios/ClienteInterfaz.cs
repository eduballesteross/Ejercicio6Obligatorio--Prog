using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio6Obligatorio.Dtos;

namespace Ejercicio6Obligatorio.Servicios
{
    /// <summary>
    /// Listados de métodos que engloban al ente Cliente
    /// ebp - 180124
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// Método que sirve para dar de alta a un cliente
        /// </summary>
        /// <param name="listaCliente"></param>
        public void DarAltaCliente(List<ClienteDto>listaCliente);

        /// <summary>
        /// Método que sirve para ordenar mediante la edad los distintos clientes a través del método Burbuja
        /// </summary>
        /// <param name="listaCliente"></param>
        public void OrdenarListaCliente(List<ClienteDto> listaCliente);
    }
}
