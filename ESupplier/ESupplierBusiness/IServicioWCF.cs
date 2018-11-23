using ESupplierBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Http;

namespace ESupplierBusiness
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioWCF
    {
        [OperationContract]
        void DoWork();


        

        [OperationContract]
        void  PostWINNERS(WINNERS wINNERS);


    }
}
