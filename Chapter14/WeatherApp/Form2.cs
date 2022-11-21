using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form2 : Form
    {
        public static Object item;
        public Form1 f1;

        public Form2(Form1 f)
        {
            f1 = f;
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pbJapan.ImageLocation = "https://www.phaj.or.jp/distribution/ironworks/images/0.png";
        }

        private void index_change(object sender, EventArgs e)
        {
            item = ((ComboBox)sender).SelectedItem;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            ComboBox fm1_comboBox = (ComboBox)f1.Controls["cbRegion"];
            fm1_comboBox.SelectedItem = item;

            this.Close();
        }
    }
}
