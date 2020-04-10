using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vezba1.Server.SignalR
{
    public class hab:Hub
    {
        public async Task DodajArtikal()
        {
            await Clients.Caller.SendAsync("KlijentMetoda", "Pozdravlja vas server!");
        }

    }
}
