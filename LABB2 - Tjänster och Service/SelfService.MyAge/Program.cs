using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.MyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseAddress
            Uri baseAddress = new Uri("http://localhost:8080/SelfService.MyAge");
            //Servicehost
            ServiceHost selfServiceHost = new ServiceHost(typeof(AgeCheckerService), baseAddress);
            try
            {
                //ABC - Endpoint
                selfServiceHost.AddServiceEndpoint(typeof(IAge), new WSHttpBinding(), "IAgeCheckerService");

                //Metadata
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
                selfServiceHost.Description.Behaviors.Add(smBehavior);

                //Startar tjänsten
                selfServiceHost.Open();
                Console.WriteLine("Tjänsten är öppen! ");
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
