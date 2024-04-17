using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sb_sharp_u9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string [] str = txtBox1.Text.Split(' ');

            for (int i = 0; i < str.Length; i++)
            {
                lstBox.Items.Add(str[i]);
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string[] str = txtBox2.Text.Split(' ');

            for (int i = str.Length-1; i >= 0; i--)
            {
                lbl.Content +=  $"{str[i]} ";
            }
        }
    }
}