using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.HarryPotter
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseAddress
            Uri baseAddress = new Uri("http://localhost:8080/SelfService.HarryPotter");

            //ServiceHost
            ServiceHost selfServiceHost = new ServiceHost(typeof(HarryPotterBooksCheckerService), baseAddress);
            try
            {
                //ABC-Endpoint
                selfServiceHost.AddServiceEndpoint(typeof(IHarryPotterBooks), new WSHttpBinding(), "HarryPotterCheckerService");

                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior {HttpGetEnabled = true};
                selfServiceHost.Description.Behaviors.Add(smBehavior);

                selfServiceHost.Open();
                Console.WriteLine("Tjänsten är öppen");
                Console.ReadKey();

            }
            catch (CommunicationException ex)
            {
                selfServiceHost.Close();
                Console.WriteLine($"Ett kommunikationsfel har uppstått.: {ex.Message}");
                Console.ReadKey();
                throw;
            }
        }
    }
}
