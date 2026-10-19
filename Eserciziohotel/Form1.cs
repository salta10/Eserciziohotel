using System;

using System.Windows.Forms;

namespace Eserciziohotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_n1_Click(object sender, EventArgs e)
        {

            string stanza = cmb_n1.Text;
            string stagione = cmb_n2.Text;
            int giorni = Convert.ToInt32(txt_n1.Text);
            bool Parcheggio = chk_n1.Checked;


            double tariffaGiornaliera = 0;
            double sconto1 = 0.75;
            double sconto2 = 0.65;

            if (stanza == "Base (B)")
            {
                if (stagione == "Bassa Stagione (BS)")
                {
                    tariffaGiornaliera = 15;
                }
                else if (stagione == "Media Stagione (MS)")
                {
                    tariffaGiornaliera = 20;
                }
                else if (stagione == "Alta Stagione (AS)")
                {
                    tariffaGiornaliera = 25;
                }
            }
            else if (stanza == "Media (M)")
            {
                if (stagione == "Bassa Stagione (BS)")
                {
                    tariffaGiornaliera = 30;
                }
                else if (stagione == "Media Stagione (MS)")
                {
                    tariffaGiornaliera = 35;
                }
                else if (stagione == "Alta Stagione (AS)")
                {
                    tariffaGiornaliera = 40;
                }
            }
            else if (stanza == "Alta (A)")
            {
                if (stagione == "Bassa Stagione (BS)")
                {
                    tariffaGiornaliera = 45;
                }
                else if (stagione == "Media Stagione (MS)")
                {
                    tariffaGiornaliera = 50;
                }
                else if (stagione == "Alta Stagione (AS)")
                {
                    tariffaGiornaliera = 55;
                }
            }

            double costoStanza = 0;
            if (giorni <= 2)
            {

                costoStanza = giorni * tariffaGiornaliera;
            }
            else if (giorni <= 7)
            {

                double primi2Giorni = 2 * tariffaGiornaliera;
                double giorniRimanenti = (giorni - 2) * (tariffaGiornaliera * sconto1);
                costoStanza = primi2Giorni + giorniRimanenti;
            }
            else
            {

                double primi2Giorni = 2 * tariffaGiornaliera;
                double successivi5Giorni = 5 * (tariffaGiornaliera * sconto1);
                double oltre7Giorni = (giorni - 7) * (tariffaGiornaliera * sconto2);
                costoStanza = primi2Giorni + successivi5Giorni + oltre7Giorni;
            }


            double costoParcheggio = 0;
            if (Parcheggio)
            {
                costoParcheggio = giorni * 5;
            }


            double totale = costoStanza + costoParcheggio;

            MessageBox.Show("Costo totale del soggiorno: " + totale + " €");
            MessageBox.Show("Grazie per aver utilizzato il nostro servizio di prenotazione! Speriamo di rivederti presto.");
        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
