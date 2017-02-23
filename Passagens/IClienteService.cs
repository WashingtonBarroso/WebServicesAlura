using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
   //WCF que essa interface é um contrato de serviço
   [ServiceContract]
   public interface IClienteService
    {
        [OperationContract]
        void Add(Cliente c);

        [OperationContract]
        Cliente Buscar(string nome);
    }
}
