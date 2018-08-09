using System;
using System.ServiceModel;

// netsh http add urlacl url=http://+:80/ user=DOMAIN\user
// wcf-servicehost-access-right
// netsh http add urlacl url=http://+:8080/ user=vilh

// netsh http add urlacl url=http://+:8080/ user=vilh
// netsh http add urlacl url=http://localhost:8080 user=vilh

// I closed Visual studio IDE and reopened it by right clicking on the Visual Studio icon and saying "Run as Administrator", Then when I ran the host, It worked!!!
// https://stackoverflow.com/questions/8727293/http-could-not-register-url-http-8000-hellowcf-your-process-does-not-have

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();

                Console.WriteLine("Host Created @ " + DateTime.Now.ToString());
                Console.ReadLine();


            }
        }
    }
}
