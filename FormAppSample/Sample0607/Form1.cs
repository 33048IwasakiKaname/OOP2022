using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (int.Parse(tbNum2.Text) == 0 || numUD2.Value == 0) {
                MessageBox.Show("0除算はできません", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                tbAns.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
                tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();

                numAns.Value = numUD1.Value / numUD2.Value;
                numMod.Value = numUD1.Value % numUD2.Value;
            }
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
