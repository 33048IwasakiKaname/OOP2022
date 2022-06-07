using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private int ans;
        private int num;
        private Random random = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            num = (int)nuNum.Value;

            if (ans == num) {
                labelAns.Text = "正解！";
            } else if(ans > num) {
                labelAns.Text = "もっと大きいよ";
            } else {
                labelAns.Text = "もっと小さいよ";
            }           
        }

        private void Form1_Load(object sender, EventArgs e) {
            radioButton10.Visible = false;
            radioButton50.Visible = false;
            radioButton100.Visible = false;
            changeButton.Visible = false;
            ans = random.Next(1, 50);
        }

        private void changeButton_Click(object sender, EventArgs e) {
            if (radioButton10.Checked) {
                label1.Text = "1～10の中から当ててね";
                ans = random.Next(1,10);
            }else if (radioButton50.Checked) {
                label1.Text = "1～50の中から当ててね";
                ans = random.Next(1,50);
            } else if (radioButton100.Checked) {
                label1.Text = "1～100の中から当ててね";
                ans = random.Next(1,100);
            }
            label2.Text = ans.ToString();
        }

        private void checkButton_Click(object sender, EventArgs e) {
            if (settingCheck.Checked) {
                radioButton10.Visible = true;
                radioButton50.Visible = true;
                radioButton100.Visible = true;
                changeButton.Visible = true;
            }else{
                radioButton10.Visible = false;
                radioButton50.Visible = false;
                radioButton100.Visible = false;
                changeButton.Visible = false;
            }
        }
    }
}
