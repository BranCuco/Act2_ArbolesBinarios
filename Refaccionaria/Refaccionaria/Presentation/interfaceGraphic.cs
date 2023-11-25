using Refaccionaria.BusinessLogic;
using Refaccionaria.DataAccess;

namespace Refaccionaria.Presentation
{
    public class interfaceGraphic : Form1
    {
        private CamionService _service;

        public interfaceGraphic()
            : base() // Llamada al constructor base
        {
            _service = new CamionService(new CamionDAO());
        }

    }
}
