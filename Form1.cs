using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Entities;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lucrari l = new Lucrari();
            Sectiuni s = new Sectiuni();
            foreach (var i in Sectiuni.lstSectiuni)
                cb_lstSectiuni.Items.Add(i.DenumS);

            displayLucrari();
        }
        private void displayLucrari()
        {
            lv_lstLucrari.Items.Clear();
            foreach (var j in Lucrari.lstLucrari)
            {
                ListViewItem lvi = new ListViewItem(j.CodL.ToString());
                lvi.SubItems.Add(j.DenumL);
                lvi.SubItems.Add(j.Sectiune.ToString());
                lvi.Tag = j;
                lv_lstLucrari.Items.Add(lvi);
            }
        }

        private void lv_lstLucrari_MouseClick(object sender, MouseEventArgs e)
        {
            Lucrari item=(Lucrari)lv_lstLucrari.SelectedItems[0].Tag;
            Form2 f = new Form2(item);
            if (f.ShowDialog() == DialogResult.OK)
                 displayLucrari();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.Create("s_lucrari.bin"))
            {
                foreach (var lucrare in Lucrari.lstLucrari)
                    formatter.Serialize(s, lucrare);
            }

            formatter = new BinaryFormatter();
            using (FileStream s = File.Create("s_sectiuni.bin"))
            {
                foreach (var sectiune in Sectiuni.lstSectiuni)
                    formatter.Serialize(s, sectiune);
            }
        }

        private void afisareLucrari(List<Lucrari> lucrari)
        {
            lv_sectiuni.Items.Clear();
            foreach (var j in lucrari)
            {
                ListViewItem lvi = new ListViewItem(j.CodL.ToString());
                lvi.SubItems.Add(j.DenumL);
                lvi.SubItems.Add(j.Sectiune.ToString());
                lv_sectiuni.Items.Add(lvi);
            }
        }

        private void cb_lstSectiuni_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nr_lucrari = 0;
            List<Lucrari> lucrari = new List<Lucrari>();
            var denumS = cb_lstSectiuni.SelectedItem.ToString();
            foreach (var i in Sectiuni.lstSectiuni)
            {
                if (i.DenumS == denumS)
                {
                    int codS = i.CodS;
                    foreach (var j in Lucrari.lstLucrari)
                    {
                        if (j.Sectiune == codS)
                        {
                            lucrari.Add(j);
                            nr_lucrari++;
                        }
                    }
                }
            }
            afisareLucrari(lucrari);
            nr_lucrari*=15;
            tb_durata_totala.Text = nr_lucrari.ToString();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = String.Empty;
            e.Graphics.DrawString("Raport Sectiuni - Lucrari", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(45,50));
            foreach(var s in Sectiuni.lstSectiuni)
            {
                text += "--------------------------------------------------------\n";
                text += s.DenumS + "\n";
                foreach(var l in Lucrari.lstLucrari)
                {
                    if(l.Sectiune==s.CodS)
                        text += "\t"+l.DenumL + "\n";
                }
            }
            text += "--------------------------------------------------------\n";
            e.Graphics.DrawString(text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 100));
           
        }
    }
}
