using Refaccionaria.DataAccess;
using System.Linq;

namespace Refaccionaria.BusinessLogic
{
    public class CamionService
    {
        private CamionDAO camionDAO;

        public CamionService(CamionDAO camionDAO)
        {
            this.camionDAO = camionDAO;
        }
        public Camion[] TodosLosCamiones()
        {
            return camionDAO.RegresaCamiones();
        }
        public Camion[] BuscarCamiones(int id, string nombre, decimal tonelaje, string marca, string placas)
        {
            var camiones = camionDAO.RegresaCamiones();

            if (id != 0)
            {
                camiones = camiones.Where(c => c.Clave == id).ToArray();
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                camiones = camiones.Where(c => c.Nombre.Contains(nombre)).ToArray();
            }

            if (tonelaje != 0)
            {
                camiones = camiones.Where(c => c.Tonelaje == tonelaje).ToArray();
            }

            if (!string.IsNullOrEmpty(marca))
            {
                camiones = camiones.Where(c => c.Marca.Contains(marca)).ToArray();
            }

            if (!string.IsNullOrEmpty(placas))
            {
                camiones = camiones.Where(c => c.Placas.Contains(placas)).ToArray();
            }

            return camiones;
        }




    }
}
