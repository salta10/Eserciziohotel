using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eserciziohotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

            

        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string stanza, stagione;
            int prezzo , giorni = int.Parse(txt_n1.Text);


            if (cmb_n1.SelectedItem == "Base(B)")
            {
                if (cmb_n3.SelectedItem == "Bassa Stagione (BS)")
                {
                  if (giorni <= 2)
                  {                        
                       if (giorni == 2)
                       {
                           prezzo = 15 * 2;
                       }
                       else
                       {
                           prezzo = 15;
                       }                      
                  }
                    else if (giorni > 2 && giorni < 7)
                    {
                        if (giorni == 2)
                        {
                            prezzo = 15 * 2;
                        }
                        else
                        {
                            prezzo = 15;
                        }
                    }
                    MessageBox.Show(prezzo.ToString());

                }
            }
           
        }
    }
}
