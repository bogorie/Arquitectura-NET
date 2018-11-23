using ESupplierBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ESupplierBusiness
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioWCF.svc o ServicioWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioWCF : IServicioWCF
    {

        private Controllers.WINNERSController controlador = new Controllers.WINNERSController();

        public void DoWork()
        {
        }

        public void PostWINNERS(WINNERS wINNERS) {
            controlador.PostWINNERS(wINNERS);
        }

        


       
    }
}
