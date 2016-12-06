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
using Oregon_Trail.Classes;


namespace Oregon_Trail.Windows
{
    /// <summary>
    /// Interaction logic for Continue.xaml
    /// </summary>
    public partial class Continue : Window
    {

        public Continue()
        {
            InitializeComponent();
            loadinfo(this);
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            Startwindow start_win = new Startwindow();
            start_win.Show();
            this.Close();
        }

        public static void loadinfo(Continue Win)
        {
            string progress, city, date, miles, money, health, text;
            string Notstarted = " Game Not@ Started";
            Notstarted = Notstarted.Replace("@", Environment.NewLine);

            for(int i = 0; i < db.EnabledGames.Count; i++)
            {
                if (db.EnabledGames[i] == true)
                {
                    progress = Game.GameList[i].Progress.ToString();
                    city = Game.GameList[i].CurrentLocation;
                    date = Game.GameList[i].CurrentDay;
                    miles = Game.GameList[i].MilesTraveled.ToString();
                    money = Game.GameList[i].CurrentMoney.ToString();
                    health = Game.GameList[i].CurrentHealth.ToString();

                    text = String.Format(" Progress- {0}@ City- {1}@ Date- {2}@ Miles- {3}@ Money- {4}@ Health- {5}@",progress,city,date, miles, money, health);
                    text = text.Replace("@", Environment.NewLine);

                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            Win.game1Desc.Text = Notstarted;
                            break;
                        case 1:
                            Win.game2Desc.Text = Notstarted;
                            break;
                        case 2:
                            Win.game3Desc.Text = Notstarted;
                            break;
                    }
                }
            }


        }

        private void game1Button_Click(object sender, RoutedEventArgs e)
        {
            if(db.EnabledGames[0] == true)
            {
                //ADD SUPPORT
            }
            else if(db.EnabledGames[0] == false)
            {
                NewGame game1 = new NewGame(0, this);
                game1.Show();
                this.Visibility = Visibility.Hidden;
            }
        }

        private void game2Button_Click(object sender, RoutedEventArgs e)
        {
            if (db.EnabledGames[1] == true)
            {
                //ADD SUPPORT
            }
            else if (db.EnabledGames[1] == false)
            {
                NewGame game1 = new NewGame(1, this);
                game1.Show();
                this.Visibility = Visibility.Hidden;
            }
        }

        private void game3Button_Click(object sender, RoutedEventArgs e)
        {
            if (db.EnabledGames[2] == true)
            {
                //ADD SUPPORT
            }
            else if (db.EnabledGames[2] == false)
            {
                NewGame game1 = new NewGame(2, this);
                game1.Show();
                this.Visibility = Visibility.Hidden;
            }
        }



        #region adsf
        /*
                    string progress, city, date, miles, money, health;

            for(int i = 0; i < Game.GameList.Count; i++)
            {
                if(Game.EnabledGames[i] != false)
                {
                    progress = ($"Progress: {($"{Game.GameList[i].Progress.ToString()}%")}");     
                    city = ($"Location: {Game.GameList[i].CurrentLocation}");         
                    date = ($"Date: {Game.GameList[i].CurrentDay}");         
                    miles = ($"Miles: {Game.GameList[i].MilesTraveled.ToString()}");        
                    money = ($"Money: {($"{Game.GameList[i].CurrentMoney.ToString()}")}");        
                    health = ($"Health: {Game.GameList[i].CurrentHealth}");

                    string display = String.Format(" {0}@ {1}@ {2}@ {3}@ {4}@ {5}@ {6}@", progress, city, date, miles, money, health);
                    display = display.Replace("@", Environment.NewLine);

                    switch (i)
                    {
                        case 0:
                            con.game1Desc.Text = display;
                            break;
                        case 1:
                            con.game2Desc.Text = display;
                            break;
                        case 2:
                            con.game3Desc.Text = display;
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            con.game1Desc.Text = "Game not started";
                            break;
                        case 1:
                            con.game2Desc.Text = "Game not started";
                            break;
                        case 2:
                            con.game3Desc.Text = "Game not started";
                            break;
                    }
                }

                
            }
        */
        #endregion

    }
}
