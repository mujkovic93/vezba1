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

            DB.Artiklis.Add(new Artikli("patlidzan", "234", 23));
            DB.Artiklis.Add(new Artikli("fasf", "234", 23));
            DB.Artiklis.Add(new Artikli("fasfas", "234", 23));
            DB.SaveChanges();
            var sviArt = DB.Artiklis.ToList();
            await Clients.Caller.SendAsync("KlijentMetoda", sviArt);
        }

        public async Task Korpa(Artikli a)
        {

            Baza.Baza DB = new Baza.Baza();

            DB.Korpaas.Add(new Korpaa(a));

            await DB.SaveChangesAsync();


            Console.WriteLine($"Kupac je dodao u bazi: {a.Ime}");
        }
        public async Task Uklonio(Artikli b)
        {
            Console.WriteLine($"Kupac je uklonio: {b.Ime}");
            //korpa.Remove(b);
            //await Clients.Caller.SendAsync("DajKorpu", korpa);
        }

       


    }
}
