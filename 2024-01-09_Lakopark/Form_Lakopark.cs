using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2024_01_09_Lakopark
{
    public partial class Form_Lakopark : Form
    {
        List<Lakopark> lakoparkok = new List<Lakopark>(); //-- összes lakópark összes adata
        Adatbazis db = new Adatbazis();
        int aktualisParkIndex = 0; //-- Melyik lakóparkot kell megjeleníteni
        int hazKepeMeret = 50;
        public Form_Lakopark()
        {
            InitializeComponent();
        }

        private void Form_Lakopark_Load(object sender, EventArgs e)
        {
            //-- adatok betöltése az adatbázisból
            lakoparkok = db.parkadatokBetoltese();
            parkAdatokMegjelenitese();
        }

        private void parkAdatokMegjelenitese()
        {
            panel_Epuletek.Controls.Clear();
            this.Text=$"{lakoparkok[aktualisParkIndex].LakoparkNeve} lakópark adatai";
            //pictureBox_Nevado.Image = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{lakoparkok[aktualisParkIndex].LakoparkNeve}.jpg");
            pictureBox_Nevado.Image = lakoparkok[aktualisParkIndex].getNevadoKep();
            //pictureBox_Nevado.SizeMode=ImageLayout.Stretch

            for (int utca = 0; utca < lakoparkok[aktualisParkIndex].UtcakSzama; utca++)
            {
                for (int hazszam = 0; hazszam < lakoparkok[aktualisParkIndex].TelkekSzama; hazszam++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = lakoparkok[aktualisParkIndex].getHazKep(utca, hazszam);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(hazKepeMeret, hazKepeMeret);
                    pb.Location = new Point(hazszam * hazKepeMeret, utca * hazKepeMeret);
                    pb.Tag = $"{utca};{hazszam}";
                    pb.Click += hazraClick;
                    panel_Epuletek.Controls.Add(pb);
                }
            }
            if(aktualisParkIndex == 0)
            {
                button_balNyil.Hide();
                button_Jobbra.Show();
            }
            else if (aktualisParkIndex==lakoparkok.Count-1)
            {
                button_Jobbra.Hide();
                button_balNyil.Show();
            }
            else
            {
                button_balNyil.Show();
                button_Jobbra.Show();
            }
        }

        private void hazraClick(object sender, EventArgs e)
        {
            //-- ház szintjeinek a végtelenített növelése
            PictureBox pb = (PictureBox)sender;
            string[] parameterek = pb.Tag.ToString().Split(';');
            int utca = int.Parse(parameterek[0]);
            int hazszam = int.Parse(parameterek[1]);
            lakoparkok[aktualisParkIndex].Hazak[utca, hazszam]++;
            if(lakoparkok[aktualisParkIndex].Hazak[utca, hazszam] > 3) 
            { 
                lakoparkok[aktualisParkIndex].Hazak[utca, hazszam] = 0; 
            }
            pb.Image = lakoparkok[aktualisParkIndex].getHazKep(utca+1, hazszam+1);
        }

        private void button_Jobbra_Click(object sender, EventArgs e)
        {
            if (aktualisParkIndex<lakoparkok.Count-1)
            {
                aktualisParkIndex++;

            }
            parkAdatokMegjelenitese();
        }

        private void button_balNyil_Click(object sender, EventArgs e)
        {
            if (aktualisParkIndex!=0)
            {
                aktualisParkIndex--;
            }
            parkAdatokMegjelenitese();
        }
    }
}
