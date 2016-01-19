using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_service
{
    [ServiceContract(Namespace = "http://WCF_Service")]
    interface IBmi
    {
        [OperationContract]
        string Calculate(int height, int weight);
    }
}
