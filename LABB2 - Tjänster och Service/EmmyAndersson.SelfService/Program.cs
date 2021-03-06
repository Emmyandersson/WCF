﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;


namespace EmmyAndersson.SelfService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base Address
            Uri baseAddress = new Uri("http://localhost:8080/EmmyAndersson.SelfService");
            //ServiceHost
            ServiceHost selfServiceHost = new ServiceHost(typeof(BmiCheckerService), baseAddress);

            try
            {
                //ABC  Endpoint
                selfServiceHost.AddServiceEndpoint(typeof(IBmi), new WSHttpBinding(), "BmiCheckerService");

                //Metadata för att hitta servicen och visa WSDL dokumentet.
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
                selfServiceHost.Description.Behaviors.Add(smBehavior);

                //Startar tjänsten
                selfServiceHost.Open();
                Console.WriteLine("Tjänsten är öppen.");
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
