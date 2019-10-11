using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//ou je stock toutes toutes les fonction a appeler dans java script
namespace TestTchatSignalR.hub
{
    public class TestHub: Hub
    {
      
        public void Hello(string message)

        {
            //caller = il n y a que celui qui a appeler la fonction qui recois le message
            Clients.Caller.helloClient(message);
        }
        public void Send(string name, string message,string color)
        {
            //all tous le monde recois le message 
            Clients.All.broadcastMessage(name, message, color);
        }
        
    }
}
