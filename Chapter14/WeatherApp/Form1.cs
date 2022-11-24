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

        public Dictionary<string, int> regionDict = new Dictionary<string, int>() {
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
                {"沖縄本島", 471000},
            };

        private static WebClient wc = new WebClient()
        {
            Encoding = Encoding.UTF8
        };

        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            try{
                getWeather();
            }
            catch (WebException ex){
                MessageBox.Show("error：" + ex);
                Application.Exit();
            }
            
        }

        //マップコード取得
        public static string GetMapCode(string url) {
            var mapUrl = wc.DownloadString(url);
            var jsonMap = JsonConvert.DeserializeObject<Rootobject3>(mapUrl);
            var Code = jsonMap.near.now[21];
            return Code;
        }

        public void getWeather()
        {
            tbWeatherInfo.ResetText();
            label_selected.Text = "≪" + cbRegion.SelectedItem.ToString() + "≫";

            var value = regionDict.FirstOrDefault(x => x.Key == cbRegion.SelectedItem.ToString()).Value;
            var num = string.Format("{0:000000}", value);


            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + num + ".json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //天気コード取得
            var weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + num + ".json");
            var jsonWeather = JsonConvert.DeserializeObject<Class1[]>(weather);

            var weatherCodeToday = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[0];
            weatherPb.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCodeToday + ".png");

            var weatherCodeTomorrow = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[1];
            weatherPbTomorrow.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCodeTomorrow + ".png");

            //明後日
            var weatherCodeAfTomorrow = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[2];
            weatherPbAfTomorrow.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCodeAfTomorrow + ".png");
            pb_2.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCodeAfTomorrow + ".png");

            //3日後
            var weatherCode_3 = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[3];
            pb_3.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCode_3 + ".png");

            //4日後
            var weatherCode_4 = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[4];
            pb_4.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCode_4 + ".png");

            //5日後
            var weatherCode_5 = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[5];
            pb_5.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCode_5 + ".png");

            //6日後
            var weatherCode_6 = jsonWeather[1].timeSeries[0].areas[0].weatherCodes[6];
            pb_6.ImageLocation = ("https://www.jma.go.jp/bosai/forecast/img/" + weatherCode_6 + ".png");


            //マップコード取得
            var mapCode = GetMapCode("https://www.jma.go.jp/bosai/weather_map/data/list.json");
            WeatherMap.ImageLocation = ("https://www.jma.go.jp/bosai/weather_map/data/png/" + mapCode);
            WeatherMap.SizeMode = PictureBoxSizeMode.StretchImage;

            labelReportTime.Text = json.reportDatetime.ToString();
            labelWeatherToday.Text = jsonWeather[0].timeSeries[0].areas[0].weathers[0];
            labelWeatherTomorrow.Text = jsonWeather[0].timeSeries[0].areas[0].weathers[1];
            //labelWeatherAfterTomorrow.Text = jsonWeather[0].timeSeries[0].areas[0].weathers[2];
            labelWindToday.Text = jsonWeather[0].timeSeries[0].areas[0].winds[0];
    
            tbWeatherInfo.Text = json.text;

            //今日の気温
            labelMinTemp.Text = "ー";
            labelMaxTemp.Text = jsonWeather[0].timeSeries[2].areas[0].temps[1] + "°";

            //週間の気温
            labelTmLow.Text = jsonWeather[0].timeSeries[2].areas[0].temps[2];
            labelTmHigh.Text = jsonWeather[0].timeSeries[2].areas[0].temps[3];
            labelNTmLow.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMin[1];
            labelNTmHigh.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMax[1];
            label02Low.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMin[2];
            label02High.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMax[2];
            label03Low.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMin[3];
            label03High.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMax[3];
            label04Low.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMin[4];
            label04High.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMax[4];
            label05Low.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMin[5];
            label05High.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMax[5];
            label06Low.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMin[6];
            label06High.Text = jsonWeather[1].timeSeries[1].areas[0].tempsMax[6];

        }

        private void Form1_Load(object sender, EventArgs e){
            try
            {
                var day = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                var jsonDay = JsonConvert.DeserializeObject<Class1[]>(day);

                label_1.Text = jsonDay[1].timeSeries[0].timeDefines[1].ToString("MM/dd");
                label_2.Text = jsonDay[1].timeSeries[0].timeDefines[2].ToString("MM/dd");
                label_3.Text = jsonDay[1].timeSeries[0].timeDefines[3].ToString("MM/dd");
                label_4.Text = jsonDay[1].timeSeries[0].timeDefines[4].ToString("MM/dd");
                label_5.Text = jsonDay[1].timeSeries[0].timeDefines[5].ToString("MM/dd");
                label_6.Text = jsonDay[1].timeSeries[0].timeDefines[6].ToString("MM/dd");

                cbRegion.SelectedItem = "東京都";
                getWeather();
            }
            catch (WebException ex)
            {
                MessageBox.Show("error：" + ex);
                Application.Exit();
            }
            
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}