using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmmyAndersson.SelfService
{
    [ServiceContract(Namespace = "http://EmmyAndersson.SelfService")]
    interface IBmi
    {
        [OperationContract]
        string Calculate(double height, double weight);
    }
}
