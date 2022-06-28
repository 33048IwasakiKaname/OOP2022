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
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        List<string> linkList = new List<string>();
        IEnumerable<string> xTitle;
        IEnumerable<string> xLink;

        public Form1() {
            InitializeComponent();
        }
        
        private void btRssGet_Click(object sender, EventArgs e) {

            clearItems();

            var url = cbRssUrl.Text;

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(url);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x=>(string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));
                foreach (var link in xLink) {
                    linkList.Add(link);
                }

                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);
                }
            }

            setCbRssUrl(url);
        }

        //リストボックスをクリックした時のイベント
        private void ListBoxClick(object sender, EventArgs e) {
            var index = lbRssTitle.SelectedIndex;
   
            wbBrowser.Navigate((string)linkList[index]);
        }

        //アイテムをすべて削除
        private void clearItems() {
            lbRssTitle.Items.Clear();
            linkList.Clear();
        }

        //コンボボックスに登録済みかの判定
        private void setCbRssUrl(string url) {
            if (!cbRssUrl.Items.Contains(url)) {
                cbRssUrl.Items.Add(url);
            }
        }
    }
}
