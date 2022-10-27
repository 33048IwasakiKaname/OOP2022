using System;
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
        public MainWindow() {
            
            InitializeComponent();

            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Label_Color.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        //背景色変更
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var r = byte.Parse(Text_R.Text);
            var g = byte.Parse(Text_G.Text);
            var b = byte.Parse(Text_B.Text);

            Label_Color.Background = new SolidColorBrush(Color.FromRgb(r,g,b));
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e) {
            if (Text_R == null || Text_G == null || Text_B == null ||
                Text_R.Text == "" || Text_G.Text == "" || Text_B.Text == "")
                return;

            var r = byte.Parse(Text_R.Text);
            var g = byte.Parse(Text_G.Text);
            var b = byte.Parse(Text_B.Text);

            Label_Color.Background = new SolidColorBrush(Color.FromRgb(r,g,b));
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
            Label_Color.Background = new SolidColorBrush(Color.FromRgb(color_r,color_g,color_b));          
        }

        private void Add_Click(object sender, RoutedEventArgs e) {
            var text_r = Text_R.Text;
            var text_g = Text_G.Text;
            var text_b = Text_B.Text;

            var color = new List<string>() { text_r, text_g, text_b };
            color_list.Items.Add(color);
        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
