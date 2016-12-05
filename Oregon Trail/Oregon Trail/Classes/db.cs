using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using TLog;

namespace Oregon_Trail.Classes
{
    public static class db
    {
        public static readonly SQLiteConnection dbCon = new SQLiteConnection("Data Source=oregontrail.sqlite; version=3");
        public static DataSet OTDS = new DataSet("OTDS");

        public static List<Item> GeneralStoreList = new List<Item>();
        public static List<bool> EnabledGames = new List<bool>();

        static bool second;
        
        public static async void LoadData()
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();


            await Task.Factory.StartNew(() =>
           {
           string sql = "SELECT * FROM gamestate";
           string table = "loadstuff";
           dataAdapter = new SQLiteDataAdapter(sql, dbCon);
           dataAdapter.Fill(OTDS, table);


           if (OTDS.Tables[0].Rows.Count > 0)
           {
               for (int i = 0; i < OTDS.Tables[0].Rows.Count; i++)
               {
                       EnabledGames.Add(Utility.BoolParse(int.Parse(OTDS.Tables[0].Rows[i]["isStarted"].ToString()))); 
               }
           }

           sql = "SELECT * FROM games";
           OTDS = new DataSet();
           dataAdapter = new SQLiteDataAdapter(sql, dbCon);
           dataAdapter.Fill(OTDS, table);

           for (int i = 0; i < Game.EnabledGames.Count; i++)
           {
               if (Game.EnabledGames[i] == true)
               {
                   Game newgame = new Game();

                   newgame.LeaderName = OTDS.Tables[0].Rows[i]["leaderName"]?.ToString();
                   newgame.Person1Name = OTDS.Tables[0].Rows[i]["person1"]?.ToString();
                   newgame.Person2Name = OTDS.Tables[0].Rows[i]["person2"]?.ToString();
                   newgame.Person3Name = OTDS.Tables[0].Rows[i]["person3"]?.ToString();
                   newgame.Person4Name = OTDS.Tables[0].Rows[i]["person4"]?.ToString();
                   newgame.Gamenum = int.Parse(OTDS.Tables[0].Rows[i]["Gamenum"].ToString());
                   newgame.Gamename = $"game{OTDS.Tables[0].Rows[i]["gamenum"]?.ToString()}";
                   newgame.Progress = int.Parse(OTDS.Tables[0].Rows[i]["progress"]?.ToString());
                   newgame.MilesTraveled = int.Parse(OTDS.Tables[0].Rows[i]["milesTraveled"]?.ToString());
                   newgame.CurrentLocation = OTDS.Tables[0].Rows[i]["currentLocation"]?.ToString();
                   newgame.CurrentDay = OTDS.Tables[0].Rows[i]["currentDate"]?.ToString();
                   newgame.CurrentRations = OTDS.Tables[0].Rows[i]["currentRations"]?.ToString();
                   newgame.CurrentWeather = OTDS.Tables[0].Rows[i]["currentWeather"]?.ToString();
                   newgame.CurrentMoney = int.Parse(OTDS.Tables[0].Rows[i]["currentMoney"]?.ToString());
                   newgame.CurrentHealth = OTDS.Tables[0].Rows[i]["currentHealth"]?.ToString();
                   newgame.NumOxen = int.Parse(OTDS.Tables[0].Rows[i]["numOxen"]?.ToString());
                   newgame.NumMules = int.Parse(OTDS.Tables[0].Rows[i]["numMules"]?.ToString());
                   newgame.LbsFood = int.Parse(OTDS.Tables[0].Rows[i]["lbsFood"]?.ToString());
                   newgame.LbsMuleFeed = int.Parse(OTDS.Tables[0].Rows[i]["lbsMuleFeed"]?.ToString());
                   newgame.SetsClothes = int.Parse(OTDS.Tables[0].Rows[i]["setsClothes"]?.ToString());
                   newgame.BoxBullets = int.Parse(OTDS.Tables[0].Rows[i]["boxBullets"]?.ToString());
                   newgame.Bullets = newgame.BoxBullets * 20;
                   newgame.NumWheels = int.Parse(OTDS.Tables[0].Rows[i]["numWheels"]?.ToString());
                   newgame.NumAxles = int.Parse(OTDS.Tables[0].Rows[i]["numAxles"]?.ToString());
                   newgame.NumTongues = int.Parse(OTDS.Tables[0].Rows[i]["numTongues"]?.ToString());

                   Game.GameList.Add(newgame);
               }
           }

           sql = "SELECT * FROM generalStore";
           OTDS = new DataSet();
           dataAdapter = new SQLiteDataAdapter(sql, dbCon);
           dataAdapter.Fill(OTDS, table);

           for (int i = 0; i < OTDS.Tables[0].Rows.Count; i++)
           {
               Item newitem = new Item();

               newitem.ItemName = OTDS.Tables[0].Rows[i]["itemName"].ToString();
               newitem.ItemPrice = Double.Parse(OTDS.Tables[0].Rows[i]["itemPrice"].ToString());
               newitem.ItemDesc = OTDS.Tables[0].Rows[i]["itemDesc"].ToString();
               newitem.ItemRecc = OTDS.Tables[0].Rows[i]["itemRecc"].ToString();
               newitem.ItemAmm = int.Parse(OTDS.Tables[0].Rows[i]["itemAmm"].ToString());

           }

           });
        }
    }

        
}

/*  for (int i = 0; i < OTDS.Tables[0].Rows.Count; i++)
               {
                   string gamename = OTDS.Tables[0].Rows[i]["gamenum"].ToString();
                   
                   switch (gamename)
                   {
                       case "game1":
                           {

                               int isstarted = int.Parse(OTDS.Tables[0].Rows[i]["isStarted"].ToString());

                               if (isstarted == 0)
                               {
                                   isStarted = false;
                                   Game.EnabledGames[0] = isStarted;
                               }
                               else if (isstarted == 1)
                               {
                                   isStarted = true;
                                   Game.EnabledGames[0] = isStarted;
                               }
                               
                               break;
                           }
                       case "game2":
                           {
                               int isstarted = int.Parse(OTDS.Tables[0].Rows[i]["isStarted"].ToString());

                               if (isstarted == 0)
                               {
                                   isStarted = false;
                                   Game.EnabledGames[1] = isStarted;
                               }
                               else if (isstarted == 1)
                               {
                                   isStarted = true;
                                   Game.EnabledGames[1] = isStarted;
                               }

                               break;
                           }
                       case "game3":
                           {
                               int isstarted = int.Parse(OTDS.Tables[0].Rows[i]["isStarted"].ToString());

                               if (isstarted == 0)
                               {
                                   isStarted = false;
                                   Game.EnabledGames[2] = isStarted;
                               }
                               else if (isstarted == 1)
                               {
                                   isStarted = true;
                                   Game.EnabledGames[2] = isStarted;
                               }

                               break;
                           }
                   }
             
    */

