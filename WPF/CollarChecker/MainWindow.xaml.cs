using System;
using System.Collections.Generic;
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

        //背景色変更
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            int r = int.Parse(Text_R.Text);
            int g = int.Parse(Text_G.Text);
            int b = int.Parse(Text_B.Text);

            Label_Color.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e) {
            if (Text_R == null || Text_G == null || Text_B == null ||
                Text_R.Text == "" || Text_G.Text == "" || Text_B.Text == "")
                return;

            int r = int.Parse(Text_R.Text);
            int g = int.Parse(Text_G.Text);
            int b = int.Parse(Text_B.Text);

            Label_Color.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {


        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
