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

            //数字判定

            if (ans == num) {
                labelAns.Text = "正解！";
            } else if(ans > num) {
                labelAns.Text = "もっと大きいよ";
            } else {
                labelAns.Text = "もっと小さいよ";
            }           
        }

        //初期設定
        private void Form1_Load(object sender, EventArgs e) {
            radioButton10.Visible = false;
            radioButton50.Visible = false;
            radioButton100.Visible = false;

            //乱数生成
            ans = random.Next(1, 50);

            //デバッグ用答え
            label2.Text = ans.ToString();

            //ラジオボタンデフォルトチェック
            radioButton50.Checked = true;
        }

        //1～10までのラジオボタン判定
        private void radioButton10_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "1～10の中から当ててね";
            ans = random.Next(1, 10); //乱数生成
            label2.Text = ans.ToString(); //デバッグ用答え
        }

        //1～50までのラジオボタン判定
        private void radioButton50_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "1～50の中から当ててね";
            ans = random.Next(1, 50); //乱数生成
            label2.Text = ans.ToString(); //デバッグ用答え
        }

        //1～100までのラジオボタン判定
        private void radioButton100_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "1～100の中から当ててね";
            ans = random.Next(1, 100); //乱数生成
            label2.Text = ans.ToString(); //デバッグ用答え
        }

        //詳細設定の表示・非表示
        private void settingCheck_CheckedChanged(object sender, EventArgs e) {
            if (settingCheck.Checked) {
                radioButton10.Visible = true;
                radioButton50.Visible = true;
                radioButton100.Visible = true;
            } else {
                radioButton10.Visible = false;
                radioButton50.Visible = false;
                radioButton100.Visible = false;
            }
        }
    }
}
