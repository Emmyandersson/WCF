using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.NextThousand
{
    [ServiceContract(Namespace = "http://SelfService.NextThousand")]
    interface INextThousand
    {
        [OperationContract]
        DateTime NextThousandDays(DateTime birthDay);



    }
}
