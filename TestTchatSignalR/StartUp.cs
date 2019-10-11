using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(TestTchatSignalR.Startup))]

namespace TestTchatSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Pour plus d'informations sur la configuration de votre application, visitez https://go.microsoft.com/fwlink/?LinkID=316888


            //Perpmet d'avoir une route pour /signalr/hubs
            //app.MapSignalR();
            //La route vers hubs sera changée ici en /r2d2/hubs ==> Changer ds le JS aussi !!
            app.Map("/r2d2", map =>
            {
                
                //Permet d'autorisé le passage de tout le monde
                map.UseCors(CorsOptions.AllowAll);
                map.RunSignalR();
            });
        }
    }
}
