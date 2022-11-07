﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> ColorList = new List<MyColor>();
        MyColor mycolor = new MyColor();

        public MainWindow() {
            
            InitializeComponent();

            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor(0,0,0);
        }

        //背景色変更
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var r = byte.Parse(Text_R.Text);
            var g = byte.Parse(Text_G.Text);
            var b = byte.Parse(Text_B.Text);

            setColor(r,g,b);
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e) {
            if (Text_R == null || Text_G == null || Text_B == null ||
                Text_R.Text == "" || Text_G.Text == "" || Text_B.Text == "" || Label_Color == null)
                return;

            var r = byte.Parse(Text_R.Text);
            var g = byte.Parse(Text_G.Text);
            var b = byte.Parse(Text_B.Text);

            setColor(r,g,b);
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var color = (MyColor)((ComboBox)sender).SelectedItem;
            var color_r = color.Color.R;
            var color_g = color.Color.G;
            var color_b = color.Color.B;

            Text_R.Text = color_r.ToString();
            Text_G.Text = color_g.ToString();
            Text_B.Text = color_b.ToString();
            Label_Color.Background = new SolidColorBrush(Color.FromRgb(color_r, color_g, color_b)); 
        }

        private void Add_Click(object sender, RoutedEventArgs e) {

            var text_r = Text_R.Text;
            var text_g = Text_G.Text;
            var text_b = Text_B.Text;
            
            if (Color_cb.SelectedItem != null) {
                var colorName = ((MyColor)Color_cb.SelectedItem).Name;
                color_list.Items.Add(colorName);
            } else {
                color_list.Items.Add("R:" + text_r + " G:" + text_g + " B:" + text_b);
            }

            MyColor setColor = new MyColor();
            var r = byte.Parse(text_r);
            var g = byte.Parse(text_g);
            var b = byte.Parse(text_b);
            setColor.Color = Color.FromRgb(r, g, b);
            ColorList.Add(setColor);
        }

        private void Del_Click(object sender, RoutedEventArgs e) {
            color_list.Items.RemoveAt(color_list.SelectedIndex);
        }

        private void color_list_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Slider_R.Value = ColorList[color_list.SelectedIndex].Color.R;
            Slider_G.Value = ColorList[color_list.SelectedIndex].Color.G;
            Slider_B.Value = ColorList[color_list.SelectedIndex].Color.B;
        }

        public void setColor(byte r,byte g, byte b) {
            Label_Color.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
