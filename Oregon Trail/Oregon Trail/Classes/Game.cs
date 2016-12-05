using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trail.Classes
{
    class Game
    {
        public static List<bool> EnabledGames = new List<bool>();
        public static List<Game> GameList = new List<Game>();

        private int gamenum;
        private string gamename;
        private string leaderName;
        private string person1Name;
        private string person2Name;
        private string person3Name;
        private string person4Name;
        private Enum.Jobs leaderJob;
        private string monthLeave;
        private int numOxen;
        private int numMules;
        private int lbsFood;
        private int lbsMuleFeed;
        private int boxBullets;
        private int bullets;
        private int setsClothes;
        private int numWheels;
        private int numAxles;
        private int numTongues;




        private string currentHealth;
        private int currentMoney;
        private string currentWeather;
        private string currentRations;
        private string currentDay;
        private string currentLocation;

        private int progress;
        private int milesTraveled;



        #region properties

        public int Gamenum
        {
            get
            {
                return gamenum;
            }

            set
            {
                gamenum = value;
            }
        }

        public string Gamename
        {
            get
            {
                return gamename;
            }

            set
            {
                gamename = value;
            }
        }

        

        public string LeaderName
        {
            get
            {
                return leaderName;
            }

            set
            {
                leaderName = value;
            }
        }

        public string Person1Name
        {
            get
            {
                return person1Name;
            }

            set
            {
                person1Name = value;
            }
        }

        public string Person2Name
        {
            get
            {
                return person2Name;
            }

            set
            {
                person2Name = value;
            }
        }

        public string Person3Name
        {
            get
            {
                return person3Name;
            }

            set
            {
                person3Name = value;
            }
        }

        public string Person4Name
        {
            get
            {
                return person4Name;
            }

            set
            {
                person4Name = value;
            }
        }

        public Enum.Jobs LeaderJob
        {
            get
            {
                return leaderJob;
            }

            set
            {
                leaderJob = value;
            }
        }

        public string MonthLeave
        {
            get
            {
                return monthLeave;
            }

            set
            {
                monthLeave = value;
            }
        }

        public int NumOxen
        {
            get
            {
                return numOxen;
            }

            set
            {
                numOxen = value;
            }
        }

        public int NumMules
        {
            get
            {
                return numMules;
            }

            set
            {
                numMules = value;
            }
        }

        public int LbsFood
        {
            get
            {
                return lbsFood;
            }

            set
            {
                lbsFood = value;
            }
        }

        public int LbsMuleFeed
        {
            get
            {
                return lbsMuleFeed;
            }

            set
            {
                lbsMuleFeed = value;
            }
        }

        public int BoxBullets
        {
            get
            {
                return boxBullets;
            }

            set
            {
                boxBullets = value;
            }
        }

        public int Bullets
        {
            get
            {
                return bullets;
            }

            set
            {
                bullets = value;
            }
        }

        public int SetsClothes
        {
            get
            {
                return setsClothes;
            }

            set
            {
                setsClothes = value;
            }
        }

        public int NumWheels
        {
            get
            {
                return numWheels;
            }

            set
            {
                numWheels = value;
            }
        }

        public int NumAxles
        {
            get
            {
                return numAxles;
            }

            set
            {
                numAxles = value;
            }
        }

        public int NumTongues
        {
            get
            {
                return numTongues;
            }

            set
            {
                numTongues = value;
            }
        }

        public string CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                currentHealth = value;
            }
        }

        public int CurrentMoney
        {
            get
            {
                return currentMoney;
            }

            set
            {
                currentMoney = value;
            }
        }

        public string CurrentWeather
        {
            get
            {
                return currentWeather;
            }

            set
            {
                currentWeather = value;
            }
        }

        public string CurrentRations
        {
            get
            {
                return currentRations;
            }

            set
            {
                currentRations = value;
            }
        }

        public string CurrentDay
        {
            get
            {
                return currentDay;
            }

            set
            {
                currentDay = value;
            }
        }

        public string CurrentLocation
        {
            get
            {
                return currentLocation;
            }

            set
            {
                currentLocation = value;
            }
        }

        public int Progress
        {
            get
            {
                return progress;
            }

            set
            {
                progress = value;
            }
        }

        public int MilesTraveled
        {
            get
            {
                return milesTraveled;
            }

            set
            {
                milesTraveled = value;
            }
        }

        #endregion

        #region constructors

        public Game()
        {

        }

        public Game(string leaderName, string person1Name, string person2Name, string person3Name, string person4Name, Enum.Jobs leaderJob, string currentHealth, int currentMoney, string currentWeather, string currentRations, string currentDay, string currentLocation, string monthLeave, int numOxen, int numMules, int lbsFood, int lbsMuleFeed, int boxBullets, int bullets, int setsClothes, int numWheels, int numAxles, int numTongues, int progress, int milesTraveled)
        {
            this.LeaderName = leaderName;
            this.Person1Name = person1Name;
            this.Person2Name = person2Name;
            this.Person3Name = person3Name;
            this.Person4Name = person4Name;
            this.LeaderJob = leaderJob;
            this.CurrentHealth = currentHealth;
            this.CurrentMoney = currentMoney;
            this.CurrentWeather = currentWeather;
            this.CurrentRations = currentRations;
            this.CurrentDay = currentDay;
            this.CurrentLocation = currentLocation;
            this.MonthLeave = monthLeave;
            this.NumOxen = numOxen;
            this.NumMules = numMules;
            this.LbsFood = lbsFood;
            this.LbsMuleFeed = lbsMuleFeed;
            this.BoxBullets = boxBullets;
            this.Bullets = bullets;
            this.SetsClothes = setsClothes;
            this.NumWheels = numWheels;
            this.NumAxles = numAxles;
            this.NumTongues = numTongues;
            this.Progress = progress;
            this.MilesTraveled = milesTraveled;
        }

        /// <summary>
        /// Creates a new game using only user entered fields
        /// </summary>
        /// <param name="leaderName">Name of the wagon leader</param>
        /// <param name="person1Name">Name of passenger 1</param>
        /// <param name="person2Name">name of passenger 2</param>
        /// <param name="person3Name">name of passenger 3</param>
        /// <param name="person4Name">name of passenger 4</param>
        /// <param name="leaderJob">Profession of the wagon leader</param>
        /// <param name="monthLeave">Month that player chose to leave independence</param>
        /// <param name="numOxen">Number of oxen pulling wagon</param>
        /// <param name="numMules">Number of mules pulling wagon</param>
        /// <param name="lbsFood">Pounds of food brought</param>
        /// <param name="lbsMuleFeed">Poungs of mule feed brought</param>
        /// <param name="boxBullets">Ammount of boxes of bullets brought</param>
        /// <param name="bullets">Exact number of bullets</param>
        /// <param name="setsClothes">Sets of clothes brought</param>
        /// <param name="numWheels">Number of spare wheels brought</param>
        /// <param name="numAxles">number of spare axles brought</param>
        /// <param name="numTongues">number of spare tongues brought</param>
        public Game(string leaderName, string person1Name, string person2Name, string person3Name, string person4Name, Enum.Jobs leaderJob, string monthLeave, int numOxen, int numMules, int lbsFood, int lbsMuleFeed, int boxBullets, int bullets, int setsClothes, int numWheels, int numAxles, int numTongues)
        {
            this.LeaderName = leaderName;
            this.Person1Name = person1Name;
            this.Person2Name = person2Name;
            this.Person3Name = person3Name;
            this.Person4Name = person4Name;
            this.LeaderJob = leaderJob;
            this.MonthLeave = monthLeave;
            this.NumOxen = numOxen;
            this.NumMules = numMules;
            this.LbsFood = lbsFood;
            this.LbsMuleFeed = lbsMuleFeed;
            this.BoxBullets = boxBullets;
            this.Bullets = bullets;
            this.SetsClothes = setsClothes;
            this.NumWheels = numWheels;
            this.NumAxles = numAxles;
            this.NumTongues = numTongues;
        }

        public Game(string gameame)
        {
            Gamename = gameame;
        }

        #endregion



    }
}
