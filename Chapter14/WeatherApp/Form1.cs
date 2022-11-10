using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var num = 100000;

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + num + ".json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
        }


        private static void Form1_Load(object sender, EventArgs e) {
            var regionDict = new Dictionary<string, int>() {
                {"青森県", 20000},
                {"岩手県", 30000},
                {"宮城県", 40000},
                {"秋田県", 50000},
                {"山形県", 60000},
                {"福島県", 70000},
            };
        }
    }
}