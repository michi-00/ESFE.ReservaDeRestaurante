using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.Restaurante.EN;
using ESFE.Restaurante.DAL;

namespace ESFE.Restaurante.BL
{
    public class ReservaBL
    {
        public List<ReservaEN> MostrarReserva(ReservaEN reservaEN)
        {
            return ReservaDAL.MostrarReserva(reservaEN);
        }
        public int GuardarReserva(ReservaEN reservaEN)
        {
            return ReservaDAL.AgregarReserva(reservaEN);

        }
        public int ModificarReserva(ReservaEN reservaEN)
        {
            return ReservaDAL.ModificarReserva(reservaEN);
        }
        public int EliminarReserva(ReservaEN reservaEN)
        {
            return ReservaDAL.EliminarReserva(reservaEN);
        }
    }
}
