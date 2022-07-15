using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        //追加ボタンが押されたとき
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

            dataGridView.CurrentCell = dataGridView[0,listCarReports.Count-1];

        }

        //修正ボタンが押されたとき
        private void btUpdate_Click(object sender, EventArgs e) {

            if (listCarReports.Count > 0) {
                //インデックス取得
                var index = dataGridView.CurrentCell.RowIndex;

                listCarReports[index].Date = dateTimePicker.Value;
                listCarReports[index].Auther = cbRecorderName.Text;
                listCarReports[index].Maker = RadioButtonCheckGroup();
                listCarReports[index].CarName = cbCarName.Text;
                listCarReports[index].Report = tbReport.Text;
                listCarReports[index].Picture = pictureBox.Image;

                //データグリッドビューの再描画
                dataGridView.Invalidate();
            }
        }

        //削除ボタンが押されたとき
        private void btDelete_Click(object sender, EventArgs e) {

            if (listCarReports.Count > 0) {
                //インデックス取得
                var index = dataGridView.CurrentCell.RowIndex;

                //行削除
                listCarReports.RemoveAt(index);
            }
            buttonEnabledCheck();
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
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
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
            pictureBox.Image = listCarReports[index].Picture;
            dateTimePicker.Value =
                listCarReports[index].Date.Year > 1900 ? listCarReports[index].Date : DateTime.Today;
            KindNumberCheck(index);
        }

        //メーカーチェック
        private void KindNumberCheck(int index) {

            if (listCarReports[index].Maker == CarReport.MakerGroup.トヨタ) {
                rbToyota.Checked = true;
            }else if (listCarReports[index].Maker == CarReport.MakerGroup.日産) {
                rbNissan.Checked = true;
            } else if (listCarReports[index].Maker == CarReport.MakerGroup.スバル) {
                rbSubaru.Checked = true;
            } else if (listCarReports[index].Maker == CarReport.MakerGroup.外国車) {
                rbForeignCar.Checked = true;
            } else if (listCarReports[index].Maker == CarReport.MakerGroup.その他) {
                rbOther.Checked = true;
            } 
        }       

        //写真削除
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pictureBox.Image = null;
        }

        //ファイル保存
        private void btSave_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //ファイル開く
        private void btOpen_Click(object sender, EventArgs e) {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = listCarReports;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            buttonEnabledCheck();
        }

        //背景色の変更
        private void colorChangeBackGround(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                BackColor = colorDialog.Color;
            }
        }

        
        //サイズ変更
        private void btSizeChange_Click(object sender, EventArgs e) {
            if (pictureBox.SizeMode == PictureBoxSizeMode.Zoom) {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
            pictureBox.SizeMode++;
        }
    }
}
