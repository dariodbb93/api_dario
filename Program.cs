using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.SelfHost;


namespace WebApiDario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var config = new HttpSelfHostConfiguration("http://localhost:8080");
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
                );


            using (var server = new HttpSelfHostServer(config))
            {

                server.OpenAsync().Wait();
                Console.WriteLine("il server locale è partito ed è in ascolto");
                Console.ReadLine();

            }

        }
    }
}
