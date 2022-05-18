using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_TogniEmanuele_GestioneArticoli
{
    public partial class Form1 : Form
    {
        Dictionary<string, Articolo> articoli;
        public Form1()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var a = new Articolo(txtCodice.Text, txtDescrizione.Text, cmbUnitaDiMisura.Text, Convert.ToDouble(txtPrezzo.Text));
            if (articoli.ContainsKey(a.Codice))
                articoli[a.Codice] = a;
            else articoli.Add(a.Codice, a);

            lblArticoli.Text = $"Articoli({articoli.Count})";
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstVisualizza.Items.Clear();
            switch (cmbScelta.Text)
            {
                case "Visualizza articoli":
                    foreach(KeyValuePair<string, Articolo> kvp in articoli)
                    {
                        lstVisualizza.Items.Add(kvp.Value.Visualizzati());
                    }
                    break;
            }
        }
    }
}
