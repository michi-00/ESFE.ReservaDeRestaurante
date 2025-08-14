using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.Restaurante.EN;
using ESFE.Restaurante.DAL;

namespace ESFE.Restaurante.BL
{
    public class ClienteBL
    {
        public List<ClienteEN> MostrarCliente(ClienteEN clienteEN)
        {
            return ClienteDAL.MostrarCliente(clienteEN);
        }
        public int GuardarCliente(ClienteEN clienteEN)
        {
            return ClienteDAL.AgregarCliente(clienteEN);
        }
        public int ModificarCliente(ClienteEN clienteEN)
        {
            return ClienteDAL.ModificarCliente(clienteEN);
        }
        public int EliminarCliente(ClienteEN clienteEN)
        {
            return ClienteDAL.EliminarCliente(clienteEN);
        }
    }
}
