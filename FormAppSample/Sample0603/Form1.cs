using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            tbAns.Text = (int.Parse(tbSuu1.Text) + int.Parse(tbsuu2.Text)).ToString();
            nuAns.Text = (nuUD1.Value + nuUD2.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            tbSuu1.Text = "";
            tbsuu2.Text = "";
            tbAns.Text = "";

            nuUD1.Value = 0;
            nuUD2.Value = 0;
            nuAns.Text = "";
        }

        private void tbAns_TextChanged(object sender, EventArgs e) {

        }
    }
}
