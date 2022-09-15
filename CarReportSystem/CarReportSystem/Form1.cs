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
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        Settings settings = Settings.getInstance();

        //住所データ管理用データ
        //BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
        }

        //ロードされたとき
        private void Form1_Load(object sender, EventArgs e) {

            //画像調整
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // TODO: このコード行はデータを 'infosys202205DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202205DataSet.CarReportDB);


            try {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {

            }
        }

        //追加ボタンが押されたとき(DB〇)
        private void btAdd_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202205DataSet.CarReportDB.NewRow();
            newRow[1] = dateTimePicker.Value;
            newRow[2] = cbRecorderName.Text;
            newRow[3] = RadioButtonCheckGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pictureBox.Image);
            //データセットへ新しいレコードを追加
            infosys202205DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202205DataSet.CarReportDB);

            //buttonEnabledCheck();
            setCbRecorder(cbRecorderName.Text);
            setCbCarName(cbCarName.Text);
            textBoxNull();

        }

        //修正ボタンが押されたとき(DB〇)
        private void btUpdate_Click(object sender, EventArgs e) {

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dateTimePicker.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbRecorderName.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = RadioButtonCheckGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pictureBox.Image;

            //保存
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202205DataSet);
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

        //終了ボタン
        private void btFinish_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //ボタンをマスクする
        private void buttonEnabledCheck() {
            
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

        //画像開くボタンが押されたとき
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
            }
        }

        //データグリッドビューがクリックされたとき
        private void DataGridViewClick(object sender, EventArgs e) {

            //データがあるかどうかを判断
            if (dataGridView.CurrentCell == null) return;

            //インデックス取得
            var index = dataGridView.CurrentCell.RowIndex;

            //テキストボックスに表示
            //cbRecorderName.Text = listCarReports[index].Auther;
            //cbCarName.Text = listCarReports[index].CarName;
            //tbReport.Text = listCarReports[index].Report;
            //pictureBox.Image = listCarReports[index].Picture;
            //dateTimePicker.Value =
            //    listCarReports[index].Date.Year > 1900 ? listCarReports[index].Date : DateTime.Today;
            //KindNumberCheck(index);
        }

        //メーカーチェック
        private void KindNumberCheck() {

            string makerName = carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString();

            //if (makerName == "トヨタ") {
            //    rbToyota.Checked = true;
            //} else if (makerName == "日産") {
            //    rbNissan.Checked = true;
            //} else if (makerName == "スバル") {
            //    rbSubaru.Checked = true;
            //} else if (makerName == "外国車") {
            //    rbForeignCar.Checked = true;
            //} else if (makerName == "その他") {
            //    rbOther.Checked = true;
            //}

            switch (carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString()) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbForeignCar.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }       

        //写真削除
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pictureBox.Image = null;
        }

        //ファイル保存
        private void btSave_Click(object sender, EventArgs e) {
            //if (saveFileDialog.ShowDialog() == DialogResult.OK) {

            //    try {
            //        //バイナリー形式でシリアル化
            //        var bf = new BinaryFormatter();
            //        using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Create)) {
            //            bf.Serialize(fs, listCarReports);
            //        }
            //    }
            //    catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        //ファイル開く
        private void btOpen_Click(object sender, EventArgs e) {
            //if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
            //    try {
            //        //バイナリー形式でシリアル化
            //        var bf = new BinaryFormatter();
            //        using (FileStream fs = File.Open(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
            //            //逆シリアル化して読み込む
            //            listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
            //            dataGridView.DataSource = null;
            //            dataGridView.DataSource = listCarReports;
            //        }
            //    }
            //    catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //}

            buttonEnabledCheck();
        }


        //サイズ変更

        private void btSizeChange_Click(object sender, EventArgs e) {
            if (pictureBox.SizeMode == PictureBoxSizeMode.Zoom) {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
            pictureBox.SizeMode++;
        }

        //背景色の変更
        private void colorChangeBackGround(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                BackColor = colorDialog.Color;
              
                settings.MainFormColor = colorDialog.Color.ToArgb();
            }
        }

        //ファイルを閉じたときシリアル化
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            var set = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };

            using (var writer = XmlWriter.Create("settings.xml", set)) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202205DataSet);

        }

        private void carReportDBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }


        //データベースグリッドビューをクリックしたとき
        private void carReportDBDataGridView_Click(object sender, EventArgs e) {

            dateTimePicker.Value = DateTime.Parse(carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString());
            cbRecorderName.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            KindNumberCheck();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!carReportDBDataGridView.CurrentRow.Cells[6].Value.Equals(DBNull.Value)) {
                pictureBox.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            } else {
                pictureBox.Image = null;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //名前検索
        private void btNameSearch_Click(object sender, EventArgs e) {
            carReportDBTableAdapter.FillByName(infosys202205DataSet.CarReportDB, tbNameSearch.Text);
        }

        //削除ボタンが押されたとき
        private void btDelete_Click(object sender, EventArgs e) {

            //if (listCarReports.Count > 0) {
            //    //インデックス取得
            //    var index = dataGridView.CurrentCell.RowIndex;

            //    //行削除
            //    listCarReports.RemoveAt(index);
            //}
            //buttonEnabledCheck();


            carReportDBDataGridView.Rows.RemoveAt(carReportDBDataGridView.CurrentRow.Index);

        }

        //クリアボタンを押したとき
        private void btClear_Click(object sender, EventArgs e) {
            dateTimePicker.Value = DateTime.Today;
            cbRecorderName.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
            pictureBox.Image = null;
            rbToyota.Checked = true;
            tbNameSearch.Text = null;
        }

        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}
