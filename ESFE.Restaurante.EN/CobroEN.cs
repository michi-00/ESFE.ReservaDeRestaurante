using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Restaurante.EN
{
    public  class CobroEN
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public string MetodoPago { get; set; }
        public int IdReserva { get; set; }
    }
}
