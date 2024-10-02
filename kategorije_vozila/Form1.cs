using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kategorije_vozila
{
    public partial class Form1 : Form
    {
        private int brojMotocikala = 0;
        private int brojAutomobila = 0;
        private int brojKamiona = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo novoVozilo = new Vozilo(txtboxModel.Text, int.Parse(txtboxGodinaproizvodnje.Text), int.Parse(txtboxBrojkotaca.Text));
                txtboxIspis.AppendText(novoVozilo.ToString() + Environment.NewLine);
                ModelVozila(novoVozilo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void ModelVozila(Vozilo vozilo)
        {
            if (vozilo.Broj_kotača == 2)
            {
                vozilo.Model = "Motocikl";
                 brojMotocikala++;
            }
            else if (vozilo.Broj_kotača == 4)
            {
                vozilo.Model = "Automobil";
                brojAutomobila++;
            }
            else if (vozilo.Broj_kotača > 4)
            {
                vozilo.Model = "Kamion";
                brojKamiona++;
            }
            else
            {
                throw new Exception("Neispravan broj kotača.");
            }

            txtboxIspis.AppendText("Kategorija: " + vozilo.Model + Environment.NewLine);
            int IspisUkupnogBroja();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtboxIspis.Text = Vozilo.ToString();
            txtboxIspis.Text = "model,,,Godina" + Environment.NewLine;

            foreach (Vozilo osoba in listaOsoba)
            {
                txtboxIspis.AppendText(osoba.ToString() + Environment.NewLine);
            }
        }
    }
}
