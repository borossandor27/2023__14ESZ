using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using WindowsRestapi;
using Newtonsoft.Json;

namespace WindowsRestapi
{
    public partial class Form1 : Form
    {
        string endPointUrl = "https://retoolapi.dev/KqpqJ9/data";
        HttpClient client = new HttpClient();

        List<Dolgozo> adatok = new List<Dolgozo>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            restapiAdatok();
            listBox_Adatok.Items.AddRange(adatok.ToArray());
        }
        private async void restapiAdatok()
        {
            listBox_Adatok.Items.Clear();
            var request = new HttpRequestMessage(HttpMethod.Get, endPointUrl);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                adatok = Dolgozo.FromJson(jsonString);
                listBox_Adatok.Items.AddRange(adatok.ToArray());
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            //-- kiolvassuk az adatokat
            if (String.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Nincs megadva név");
                textBox_name.Focus();
                return;
            }
            long fizetes;
            if (!long.TryParse(textBox_fizetes.Text, out fizetes))
            {
                MessageBox.Show("Nem megfelelő a fizetés értéke!");
                textBox_fizetes.Focus();
                return;
            }
            //-- JSON-t alkotunk
            Dolgozo dolgozo = new Dolgozo();
            dolgozo.Name = textBox_name.Text;
            dolgozo.Salary = fizetes;
            string JsonDolgozo = JsonConvert.SerializeObject(dolgozo);
            //-- JSONString-et csinálunk és elküldjük a végpontra POST-al
            var data = new StringContent(JsonDolgozo, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            var response = client.PostAsync(endPointUrl, data).Result;
            //-- Visszajelzés a felhasználónak
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres rögzítés!");
                textBox_fizetes.Text = "";
                textBox_name.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzítés");
            }
            restapiAdatok();

        }
    }
}
