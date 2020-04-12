using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vezba1.Shared;

namespace vezba1.Server.SignalR
{
    public class hab : Hub
    {
        public List<Artikli> korpa = new List<Artikli>();
        public async Task SviArtikli()
        {
            Console.WriteLine("Klijent trazi listu artikala");
            Baza.Baza DB = new Baza.Baza();
            var sviArt = DB.Artiklis.ToList();
            await Clients.Caller.SendAsync("KlijentMetoda", sviArt);
        }

        public async Task Korpa(Artikli a)
        {
            Console.WriteLine($"Kupac je dodao: {a.Ime}");
        }
        public async Task Uklonio(Artikli b)
        {
            Console.WriteLine($"Kupac je uklonio: {b.Ime}");

        }

       


    }
}
