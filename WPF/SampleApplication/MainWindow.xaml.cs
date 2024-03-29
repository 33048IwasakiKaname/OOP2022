﻿using System;
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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            seasonComboBox.SelectedIndex = getSeasonIndex();
        }

        private int getSeasonIndex() {
            DateTime date = DateTime.Now;
            var month = date.Month;
            int ret = 0;

            if (3 <= month && month <= 5) {
                return 0;
            } else if (6 <= month && month <= 8) {
                return 1;
            } else if (9 <= month && month <= 11) {
                return 2;
            } else {
                return 3;
            }

            //switch (month) {
            //    case 3:
            //    case 4:
            //    case 5:
            //        ret =  0;
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        ret = 1;
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        ret = 2;
            //        break;
            //    case 12:
            //    case 1:
            //    case 2:
            //        ret = 3;
            //        break;
            //}
            //return ret;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "チェック済み";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "未チェック";
        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";
        }

        private void yelloButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";
        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";
        }
    }
}
