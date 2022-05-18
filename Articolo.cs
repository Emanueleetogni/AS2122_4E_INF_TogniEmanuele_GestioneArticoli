using System;
using System.Collections.Generic;
using System.Text;

namespace AS2122_4E_INF_TogniEmanuele_GestioneArticoli
{
    class Articolo
    {
        string codice, descrizione, unitaDiMisura;
        double prezzo;

        public Articolo(string codice, string descrizione, string unitaDiMisura, double prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaDiMisura = unitaDiMisura;
            this.prezzo = prezzo;
        }

        public string Codice { get { return codice; } }
        public string Descrizione { get { return descrizione; } }
        public string UnitaDiMisura { get { return unitaDiMisura; } }
        public double Prezzo { get { return prezzo; } }
    }
}
