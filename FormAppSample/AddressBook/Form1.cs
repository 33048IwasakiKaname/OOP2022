using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用データ
        BindingList<Person> listPerson = new BindingList<Person>();

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

            Person newPerson = new Person() {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            if (tbName.Text != "") {
                listPerson.Add(newPerson);
                btClear.Enabled = true;
                btUpdate.Enabled = true;
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
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

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
            listPerson[index].Company = tbCompany.Text;
            listPerson[index].listGroup = GetCheckBoxGroup();
            listPerson[index].Picture = pbPicture.Image;

            //データグリッドビューの再描画
            dgvPersons.Invalidate();
        }

        //行を削除するときの処理
        private void btClear_Click(object sender, EventArgs e) {

            //インデックス取得
            var index = dgvPersons.CurrentCell.RowIndex;

            if (listPerson.Count >= 0 && index-1 >= 0) {

                //行削除
                listPerson.RemoveAt(index);

                //テキストボックスへ表示
                tbName.Text = listPerson[index - 1].Name;
                tbMailAddress.Text = listPerson[index - 1].MailAddress;
                tbAddress.Text = listPerson[index - 1].Address;
                tbCompany.Text = listPerson[index - 1].Company;
                pbPicture.Image = listPerson[index - 1].Picture;

                
            } else{
                tbName.Text = null;
                tbMailAddress.Text = null;
                tbAddress.Text = null;
                tbCompany.Text = null;
                pbPicture.Image = null;

                listPerson.RemoveAt(index);
                btClear.Enabled = false;
                btUpdate.Enabled = false;
            }

            
        }
    }
}
