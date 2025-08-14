using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.Restaurante.EN;
using ESFE.Restaurante.DAL;

namespace ESFE.Restaurante.BL
{
    public class MenuBL
    {
        public List<MenuEN> MostrarMenú(MenuEN menúEN)
        {
            return MenuDAL.MostrarMenú(menúEN);
        }
        public int GuardarMenú(MenuEN menúEN)
        {
            return MenuDAL.AgregarMenú(menúEN);
        }
        public int ModificarMenú(MenuEN menúEN)
        {
            return MenuDAL.ModificarMenú(menúEN);
        }
        public int EliminarMenú(MenuEN menúEN)
        {
            return MenuDAL.EliminarMenú(menúEN);
        }
    }
}
