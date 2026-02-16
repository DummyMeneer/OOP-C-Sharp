using Opdrachten_week_3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_3.Models
{
    public class Bankrekening
    {

        //TODO Opdracht 2: controleer of de toegang verantwoord is
        //Basis informatie
        public int Id { get; set; }


        //Rekening informatie
        public string RekeningHouderNaam { get; set; }
        public string RekeningNummer { get; set; }
        public RekeningType RekeningType { get; set; }
        public DateTime AangemaaktOp {  get; set; }
        public RekeningStatus RekeningStatus { get; set; }
        public string Wachtwoord {  get; set; }

        //Pas informatie
        public string PasNummer { get; set; }
        public DateTime PasVervaldatum {  get; set; }

        //Financiele informatie
        public double Geld {  get; set; }

        //TODO Opdracht 1: maak een constructor aan voor een Nieuwe rekening







        public void Storten(double StortBedrag, string Storter)
        {
            if (Storter == RekeningHouderNaam)
            {
                Geld += StortBedrag;
            }
            else
            {
                System.Console.WriteLine(Storter + " probeert illegaal geld te storten");
            }
        }

        public void Betalen(double BetaalBedrag, string Ontvanger, string Betaler)
        {
            if (Betaler == RekeningHouderNaam)
            {
                Geld -= BetaalBedrag;
            }
            else
            {
                System.Console.WriteLine(Betaler + " probeert illegaal geld te betalen aan " + Ontvanger);
            }

        }

        public void Ontvangen(double BetaalBedrag, string Ontvanger, string Betaler)
        {
            if (Ontvanger == RekeningHouderNaam)
            {
                Geld += BetaalBedrag;
            }
            else
            {
                System.Console.WriteLine(Betaler + " probeert illegaal geld te betalen aan " + Ontvanger);
            }

        }

    }
}
