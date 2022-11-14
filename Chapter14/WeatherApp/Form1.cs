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

        private Dictionary<string, int> regionDict = new Dictionary<string, int>() {
                {"北海道(札幌周辺)", 16000},
                {"青森県", 20000},
                {"岩手県", 30000},
                {"宮城県", 40000},
                {"秋田県", 50000},
                {"山形県", 60000},
                {"福島県", 70000},
                {"茨城県", 80000},
                {"栃木県", 90000},
                {"群馬県", 100000},
                {"埼玉県", 110000},
                {"千葉県", 120000},
                {"東京都", 130000},
                {"神奈川県", 140000},
                {"山梨県", 190000},
                {"長野県", 200000},
                {"岐阜県", 210000},
                {"静岡県", 220000},
                {"愛知県", 230000},
                {"三重県", 240000},
                {"新潟県", 150000},
                {"富山県", 160000},
                {"石川県", 170000},
                {"福井県", 180000},
                {"滋賀県", 250000},
                {"京都府", 260000},
                {"大阪府", 270000},
                {"兵庫県", 280000},
                {"奈良県", 290000},
                {"和歌山県", 300000},
                {"鳥取県", 310000},
                {"島根県", 320000},
                {"岡山県", 330000},
                {"広島県", 340000},
                {"徳島県", 360000},
                {"香川県", 370000},
                {"愛媛県", 380000},
                {"高知県", 390000},
                {"山口県", 350000},
                {"福岡県", 400000},
                {"佐賀県", 410000},
                {"長崎県", 420000},
                {"熊本県", 430000},
                {"大分県", 440000},
                {"宮崎県", 450000},
                {"鹿児島県", 460100},
                {"沖縄本島地方", 471000},
            };

        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {

            tbWeatherInfo.ResetText();

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var value = regionDict.FirstOrDefault(x => x.Key == cbRegion.SelectedItem.ToString()).Value;
            var num = string.Format("{0:000000}", value);
            

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + num + ".json");
            var weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + num + ".json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            var jsonWeather = JsonConvert.DeserializeObject<Class1[]>(weather);
            var weatherCode = jsonWeather[0].timeSeries[0].areas[0].weatherCodes[0];
            weatherPb.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCode + ".svg");
            
            

            tbWeatherInfo.Text = jsonWeather[0].timeSeries[0].areas[0].weathers[0];
            

            //tbWeatherInfo.Text = json.text;
            

        }
    }
}