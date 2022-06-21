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

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用データ
        BindingList<Person> listPerson = new BindingList<Person>();

        private int count = -1;

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
             
        }

        //データ追加
        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person() {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                Registration = dateTimePicker1.Value,
                listGroup = GetCheckBoxGroup(),
            };

            if (tbName.Text != "") {
                count++;
                listPerson.Add(newPerson);
                buttonEnabledCheck();
                dgvPersons.CurrentCell = dgvPersons[0, count];
            }

            setCbCompany(cbCompany.Text);
            textBoxNull();
            clear_check();
        }

        //コンボボックスに登録済みかの判定
        private void setCbCompany(string company) {

            if (!cbCompany.Items.Contains(company)) {
                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked)
                listGroup.Add(Person.GroupType.家族);
            if (cbFriend.Checked)
                listGroup.Add(Person.GroupType.友人);
            if (cbWork.Checked)
                listGroup.Add(Person.GroupType.仕事);
            if (cbOther.Checked)
                listGroup.Add(Person.GroupType.その他);

            return listGroup;
        }


        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if(dgvPersons.CurrentCell == null) return;

            //インデックス取得
            var index = dgvPersons.CurrentCell.RowIndex;

            //テキストボックスへ表示
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            dateTimePicker1.Value =
                listPerson[index].Registration.Year > 1900 ? listPerson[index].Registration : DateTime.Today;
            
            clear_check();

            foreach (var check in listPerson[index].listGroup) {

                switch (check) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        //チェックボックスをクリア
        private void clear_check() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押されたときの処理
        private void btUpdate_Click(object sender, EventArgs e) {

            //インデックス取得
            var index = dgvPersons.CurrentCell.RowIndex;

            listPerson[index].Name = tbName.Text;
            listPerson[index].MailAddress = tbMailAddress.Text;
            listPerson[index].Address = tbAddress.Text;
            listPerson[index].Company = cbCompany.Text;
            listPerson[index].listGroup = GetCheckBoxGroup();
            listPerson[index].Picture = pbPicture.Image;
            listPerson[index].Registration = dateTimePicker1.Value;

            //データグリッドビューの再描画
            dgvPersons.Invalidate();
        }

        //行を削除するときの処理
        private void btClear_Click(object sender, EventArgs e) {

            //インデックス取得
            var index = dgvPersons.CurrentCell.RowIndex;

            //行削除
            listPerson.RemoveAt(index);

            count--;

            if (listPerson.Count > 0 ) {
                //テキストボックスへ表示
                tbName.Text = listPerson[count].Name;
                tbMailAddress.Text = listPerson[count].MailAddress;
                tbAddress.Text = listPerson[count].Address;
                cbCompany.Text = listPerson[count].Company;
                pbPicture.Image = listPerson[count].Picture; 
            } else{
                textBoxNull();
                clear_check();
                buttonEnabledCheck();
            }   
        }

        //テキストボックスを空にする
        private void textBoxNull() {
            tbName.Text = null;
            tbMailAddress.Text = null;
            tbAddress.Text = null;
            pbPicture.Image = null;
            cbCompany.Text = null;
        }

        //ボタンをマスクする
        private void buttonEnabledCheck() {
            btClear.Enabled = btUpdate.Enabled = listPerson.Count() > 0 ? true : false;
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName,FileMode.Open,FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>) bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            //コンボボックスのアイテム削除
            cbCompany.Items.Clear();

            foreach (var item in listPerson.Select(p => p.Company)) {
                //存在する会社を登録
                setCbCompany(item);
            }

            count = listPerson.Count()-1;
            buttonEnabledCheck();
        }
    }
}
