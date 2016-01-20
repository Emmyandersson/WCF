using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.NextThousand
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseAddress
            var baseAddress = new Uri("http://localhost:8080/SelfService.NextThousand");
            //ServiceHost
            ServiceHost selfServiceHost = new ServiceHost(typeof(NextThousandCheckerService),baseAddress);
            try
            {
                //Abc - endpoint
                selfServiceHost.AddServiceEndpoint(typeof(INextThousand), new WSHttpBinding(),
                    "NextThousandCheckerService");
                //Metadata
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
                selfServiceHost.Description.Behaviors.Add(smBehavior);

                //startar tjänsten
                selfServiceHost.Open();
                Console.WriteLine("Tjänsten är öppen!");
                Console.ReadKey();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine($"Kommunikations fel{ex.Message}");
                selfServiceHost.Abort();
                Console.ReadKey();
                throw;
            }
        }
    }
}
