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

        List<Adat> adatok = new List<Adat>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restapiAdatok().Wait();
            listBox_Adatok.Items.AddRange(adatok.ToArray());
        }
        async Task restapiAdatok()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, endPointUrl);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                adatok = Adat.FromJson(jsonString).ToList();

            }
        }
    }
}
