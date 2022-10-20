using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        private int ansNum = 0;
        Random rand = new Random();

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //ansNum = rand.Next(1, 25);
            ansNum = rand.Next(25) + 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button bt = (Button)sender;
            if(ansNum == int.Parse((string)bt.Content)) {
                infoDisp.Text = "正解！！";
                bt.Background = Brushes.Gold;
                return;
            }else if(ansNum < int.Parse((string)bt.Content)) {
                infoDisp.Text = "もっと小さいよ";
            }else if(ansNum > int.Parse((string)bt.Content)) {
                infoDisp.Text = "もっと大きいよ";
            }


            //if (ansNum == int.Parse((string)bt.Content)) {
            //    infoDisp.Text = "正解！！";
            //    bt.Background = Brushes.Gold;
            //} else {
            //    infoDisp.Text = int.Parse((string)bt.Content) < ansNum 
            //                                ? "もっと大きいです" : "もっと小さいです";
            //}

                bt.Background = Brushes.Red;
        }

        
    }
}
