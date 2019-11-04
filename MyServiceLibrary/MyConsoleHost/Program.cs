using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MyConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080");

            ServiceHost serviceHost = new ServiceHost(typeof(MyServiceLibrary.MyServiceLibrary), baseAddress);

            ServiceEndpoint serviceEndPoint = serviceHost.AddServiceEndpoint(typeof(IMyLibraryService),new BasicHttpBinding(), baseAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = false;
            serviceHost.Description.Behaviors.Add(smb);

            ServiceEndpoint httpServiceEndPointMex = serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "http://localhost:8080/mex");
            
            serviceHost.Open();

            Console.WriteLine("Started.....");

            foreach (var item in serviceHost.Description.Endpoints)
            {

                Console.WriteLine(item.Address);
                Console.WriteLine(item.Binding);
                Console.WriteLine(item.Contract.ContractType);

            }

            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
