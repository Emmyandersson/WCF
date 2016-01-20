using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.MyAge
{
    [ServiceContract(Namespace = "http://SelfService.MyAge")]
    interface IAge
    {
        [OperationContract]
        string HowOldAmI(DateTime birthDay);
    }
}
