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

        //テキストボックス変更時の処理
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

        //コンボボックス
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

        //データ追加処理
        private void Add_Click(object sender, RoutedEventArgs e) {

            

            MyColor setColor = new MyColor();
            var r = byte.Parse(Text_R.Text);
            var g = byte.Parse(Text_G.Text);
            var b = byte.Parse(Text_B.Text);
            setColor.Color = Color.FromRgb(r, g, b);

            var colorNameDis = ((IEnumerable<MyColor>)DataContext)
                                            .Where(c => c.Color.R == setColor.Color.R &&
                                                        c.Color.G == setColor.Color.G &&
                                                        c.Color.B == setColor.Color.B).FirstOrDefault();

            color_list.Items.Insert(0, colorNameDis?.Name ?? "R:" + Text_R.Text + " G:" + Text_G.Text + " B:" + Text_B.Text);
            ColorList.Insert(0, setColor);
        }

        //削除処理
        private void Del_Click(object sender, RoutedEventArgs e) {
            var delIndex = color_list.SelectedIndex;
            if (delIndex >= 0) {
                ColorList.RemoveAt(color_list.SelectedIndex);
                color_list.Items.RemoveAt(color_list.SelectedIndex);
            }

            
            
        }

        private void color_list_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (color_list.SelectedIndex >= 0) {
                Slider_R.Value = ColorList[color_list.SelectedIndex].Color.R;
                Slider_G.Value = ColorList[color_list.SelectedIndex].Color.G;
                Slider_B.Value = ColorList[color_list.SelectedIndex].Color.B;
            }
        }

        //色のセット
        public void setColor(byte r,byte g, byte b) {
            Label_Color.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
