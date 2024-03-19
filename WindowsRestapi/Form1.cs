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

namespace WindowsRestapi
{
    public partial class Form1 : Form
    {
        string endPointUrl = "https://retoolapi.dev/KqpqJ9/data";

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
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, endPointUrl);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                adatok = Dolgozo.FromJson(jsonString);
                listBox_Adatok.Items.AddRange(adatok.ToArray());
            }
        }
    }
}
