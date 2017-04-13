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

namespace TestingHorizontal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int a = 0; a < 10; a++)
            {
                Button b = new Button();
                b.Content = "Button"+a;
                b.Height = 75;
                b.Width = 75;
                b.Click += new RoutedEventHandler(b_Click);
                lb.Items.Add(b);
            }
        }
        public void b_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("btn clicked" + e);
        }
    }
}
