using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.HarryPotter
{
    [ServiceContract(Namespace = "http://SelfService.HarryPotter")]
    interface IHarryPotterBooks
    {
        [OperationContract]
        string BookName(string name);


    }
}
