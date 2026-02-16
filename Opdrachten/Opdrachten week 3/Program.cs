
using Opdrachten_week_3.Models;
using Opdrachten_week_3.Enums;
using System;

namespace DierenAsielDemo
{
    class Program
    {

        public static Bankrekening A;
        public static Bankrekening B;
        public static Bankrekening C;


        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {

            setup();

            //TODO Opdracht 2: maak wat hieronder staat veiliger!

            //Gebruikers storten geld
            A.Geld = 100;
            B.Geld = 200;
            C.Geld = 100;

            // Gebruiker A betaalt aan gebruiker C 20 euro
            A.Geld -= 20;
            C.Geld += 20;

            //Gebruiker B probeert 50 euro te stelen van Gebruiker C en betaalt dit aan gebruiker A
            C.Geld -= 50;
            A.Geld += 50;

        }


        //TODO Opdracht 1: verander deze setup naar een die constructors gebruikt
        public static void setup()
        {
            A = new Bankrekening();
            A.RekeningHouderNaam = "Alice";
            A.RekeningStatus = RekeningStatus.Actief;
            A.Geld = 0;
            A.Wachtwoord = "1234";
            
            B = new Bankrekening();
            B.RekeningHouderNaam = "Basim";
            B.RekeningStatus = RekeningStatus.Actief;
            B.Geld = 0;
            B.Wachtwoord = "5678";

            C = new Bankrekening();
            C.RekeningHouderNaam = "Chip";
            C.RekeningStatus = RekeningStatus.Actief;
            C.Geld = 0;
            C.Wachtwoord = "0000";

        }
    }
}