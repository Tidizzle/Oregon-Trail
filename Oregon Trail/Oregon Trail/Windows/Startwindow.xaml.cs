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
using System.Windows.Shapes;
using TLog.Log;
using System.IO;
using Oregon_Trail.Windows;

namespace Oregon_Trail.Windows
{
    /// <summary>
    /// Interaction logic for Startwindow.xaml
    /// </summary>
    public partial class Startwindow : Window
    {
        internal static Startwindow reftostart;

        public Startwindow()
        {
            InitializeComponent();
            reftostart = this;

        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.Continue contin_win = new Continue();
            contin_win.Show();
            this.Close();
        }

    }
}
