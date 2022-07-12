using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //住所データ管理用データ
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dataGridView.DataSource = listCarReports;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            CarReport newCarReport = new CarReport() {
                Date = dateTimePicker.Value,
                Auther = cbRecorderName.Text,
                Maker = RadioButtonCheckGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pictureBox.Image,
            };

            listCarReports.Add(newCarReport);
            buttonEnabledCheck();
            setCbRecorder(cbRecorderName.Text);
            setCbCarName(cbCarName.Text);
            textBoxNull();

        }

        //ラジオボタンチェック
        private CarReport.MakerGroup RadioButtonCheckGroup() {

            CarReport.MakerGroup selectedKindNumber = CarReport.MakerGroup.その他;

            if (rbToyota.Checked){
                selectedKindNumber = CarReport.MakerGroup.トヨタ;
            } else if (rbNissan.Checked) {
                selectedKindNumber = CarReport.MakerGroup.日産;
            } else if (rbSubaru.Checked) {
                selectedKindNumber = CarReport.MakerGroup.スバル;
            } else if (rbForeignCar.Checked) {
                selectedKindNumber = CarReport.MakerGroup.外国車;
            } else if (rbOther.Checked) {
                selectedKindNumber = CarReport.MakerGroup.その他;
            }

            return selectedKindNumber;
        }


            private void btFinish_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //ボタンをマスクする
        private void buttonEnabledCheck() {
            btDelete.Enabled = btUpdate.Enabled = listCarReports.Count() > 0 ? true : false;
        }

        //コンボボックス(記録者)に登録済みかの判定
        private void setCbRecorder(string company) {

            if (!cbRecorderName.Items.Contains(company)) {
                cbRecorderName.Items.Add(company);
            }
        }

        //コンボボックス(車名)に登録済みかの判定
        private void setCbCarName(string company) {

            if (!cbCarName.Items.Contains(company)) {
                cbCarName.Items.Add(company);
            }
        }

        //テキストボックスを空にする
        private void textBoxNull() {
            cbRecorderName.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (pictureOpenFileDialog.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = Image.FromFile(pictureOpenFileDialog.FileName);
            }
        }

        //データグリッドビューがクリックされたとき
        private void DataGridViewClick(object sender, EventArgs e) {
            //インデックス取得
            var index = dataGridView.CurrentCell.RowIndex;

            //テキストボックスに表示
            cbRecorderName.Text = listCarReports[index].Auther;
            cbCarName.Text = listCarReports[index].CarName;
            tbReport.Text = listCarReports[index].Report;
            dateTimePicker.Value =
                listCarReports[index].Date.Year > 1900 ? listCarReports[index].Date : DateTime.Today;
        }


        //↓続き

        //メーカーチェック
        //private void KindNumberCheck(int index) {
        //    if (listCarReports[index].Maker == listCarReports.) {
        //        rbHome.Checked = true;
        //    } else {
        //        rbMobile.Checked = true;
        //    };
        //}
    }
}
