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
using Oregon_Trail.Classes;

namespace Oregon_Trail.Windows
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        public static int Gamenum;
        public Continue Prev_win;
        public NewGame(int gamenum, Continue prevwin)
        {
            InitializeComponent();
            Gamenum = gamenum;
            Prev_win = prevwin;
        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            int i = Gamenum;

            if (leadertextbox.Text != null && professionbox.SelectedItem != null && pass1textbox.Text != null && pass3textbox.Text != null && pass4textbox.Text != null)
            {

                Game.GameList[i].LeaderName = leadertextbox.Text;

                switch (professionbox.SelectedItem.ToString())
                {
                    case "cbi1":
                        Game.GameList[i].LeaderJob = Classes.Enum.Jobs.Farmer;
                        break;
                    case "cbi2":
                        Game.GameList[i].LeaderJob = Classes.Enum.Jobs.Banker;
                        break;
                    case "cbi3":
                        Game.GameList[i].LeaderJob = Classes.Enum.Jobs.Blacksmith;
                        break;
                    case "cbi4":
                        Game.GameList[i].LeaderJob = Classes.Enum.Jobs.Carpenter;
                        break;
                }

                Game.GameList[i].Person1Name = pass1textbox.Text;
                Game.GameList[i].Person2Name = pass2textbox.Text;
                Game.GameList[i].Person3Name = pass3textbox.Text;
                Game.GameList[i].Person4Name = pass4textbox.Text;



            }
            else
            {
                MessageBox.Show("You must fill in all fields!", "Oregon Trail Error MSG", MessageBoxButton.OK);
            }

        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            Prev_win.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
    }
}
