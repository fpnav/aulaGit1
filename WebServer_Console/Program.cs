using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Owin;

namespace WebServer_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Server started");
                Console.ReadKey();
                Console.WriteLine("Server Stopped");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(ctx => ctx.Response.WriteAsync("Resposta da requisição Http"));
        }
    }
}
