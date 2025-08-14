using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Restaurante.EN
{
    public class ReservaEN
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Estado { get; set; }
        public int NumeroPersonas { get; set; }
        public string Observación { get; set; }
    }
}
