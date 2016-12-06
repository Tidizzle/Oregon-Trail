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
using Oregon_Trail.Windows;
using TLog;

namespace Oregon_Trail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static MainWindow main;
        public static TLog.Log.Log MAINLOG = new TLog.Log.Log("OregonLog");
        public MainWindow()
        {
            MAINLOG.ClearLog();
            InitializeComponent();
            Classes.db.LoadData();        
        }

        public Startwindow start_win;

        private void playbutton_Click(object sender, RoutedEventArgs e)
        {
            main = this;
            start_win = new Startwindow();
            this.
            start_win.Show();
            Close();
        }
    }
}
