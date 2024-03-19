using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsashaz
{
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            Program.db.epuletekListboxba();
        }

        private void listBox_Epuletek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                return;
            }
            Epulet epulet = (Epulet)listBox_Epuletek.SelectedItem;
            textBox_EpuletId.Text = epulet.epuletid.ToString();
            textBox_Utca.Text = epulet.utcanev;
            numericUpDown_hazSzam.Value = epulet.hazszam;
            listBox_Lakok.Items.Clear();
            foreach (Lako item in epulet.lakok)
            {
                listBox_Lakok.Items.Add(item);
            }
            textBox_LakoId.Text = "";
            textBox_LakoNev.Text = "";
            numericUpDown_SzuletesiEv.Value = numericUpDown_SzuletesiEv.Minimum;
        }
    }
}
