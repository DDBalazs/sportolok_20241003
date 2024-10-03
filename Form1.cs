using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportolok_20241003
{
    public partial class Form1 : Form
    {
        private List<Jatekosok> lista = new List<Jatekosok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btkilep_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bthozzad_Click(object sender, EventArgs e)
        {
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("Adja meg a nevet!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if (txelet.TextLength == 0)
            {
                MessageBox.Show("Adja meg a életkort!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txelet.Focus();
            }
            else if(6 > Convert.ToInt16(txelet.Text) || Convert.ToInt16(txelet.Text) > 40)
            {
                MessageBox.Show("Nem jó életkort adott meg!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txelet.Clear();
                txelet.Focus();
            }
            else
            {
                Jatekosok j=new Jatekosok();
                j.Nev = txnev.Text;
                j.Kor = Convert.ToInt16(txelet.Text);
                lista.Add(j);
                rtxadat.Text = rtxadat.Text+txnev.Text+":"+txelet.Text+" éves\n";
                txelet.Clear();
                txnev.Clear();
            }
        }

        private void rtxadat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btatlag_Click(object sender, EventArgs e)
        {
            double atlag = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                atlag = atlag + lista[i].Kor;
            }
            atlag = Math.Round(atlag / lista.Count, 2);
            MessageBox.Show(atlag.ToString(), "Átlag életkor");
        }

        private void btletszam_Click(object sender, EventArgs e)
        {
            int db = 0;
            for(int i = 0;i < lista.Count; i++)
            {
                db++;
            }
            MessageBox.Show(db.ToString(), "Csapat létszáma");
        }

        private void btlgf_Click(object sender, EventArgs e)
        {
            int min = 0;
            for(int i = 0; i<lista.Count; i++)
            {
                if(lista[i].Kor < lista[min].Kor)
                {
                    min = i;
                }
            }
            MessageBox.Show("A legfiatalbb játékos neve: " + lista[min].Nev + ", életkora: " + lista[min].Kor,"A legfiatalabb játékos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btlgi_Click(object sender, EventArgs e)
        {
            int max = 0;
            for(int i = 0; i< lista.Count; i++)
            {
                if (lista[i].Kor > lista[max].Kor)
                {
                    max = i;
                }
            }
            MessageBox.Show("A legidősebb játékos neve: " + lista[max].Nev + ", életkora: " + lista[max].Kor,"A legidősebb játékos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("sportolok.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.Close();
            fs.Close();
        }
    }
}
