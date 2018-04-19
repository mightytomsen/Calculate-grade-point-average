using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string[] note = new string[6];
            string[] eingabe = new string[6] { note1.Text, note2.Text, note3.Text, note4.Text, note5.Text, note6.Text };
            int n;

            for (int i = 0; i < 6; i++)
            {
                note[i] = eingabe[i];

                if (i == 5)
                {
                    if (String.IsNullOrEmpty(note[i]))
                    {
                        MessageBox.Show("Bitte fülle alle Felder aus!");
                    }
                    else if(int.TryParse(note[i], out n))
                    {
                        double teilnehmer = 0, gesamtnote = 0, durchschnitt = 0;
                        int nr = 1;

                        for (int j = 0; j < 6; j++)
                        {                        
                            teilnehmer += Convert.ToInt32(note[j]);
                            gesamtnote += (nr++ * Convert.ToInt32(note[j]));
                        }

                        durchschnitt = gesamtnote / teilnehmer;

                        MessageBox.Show("Der Notendurchschnitt von " + Convert.ToString(teilnehmer) + " Schülern lautet " + Convert.ToString(String.Format("{0:0.00}", durchschnitt)));
                    }

                }

            }    

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
