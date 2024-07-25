using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    [Serializable]
    public class PlayerData
    {
        public string PlayerName { get; set; } // Player name Variable
        public int ElapsedTimeInSeconds { get; set; } // Elapsed Time variable


    }

    public class LeaderBoard
    {

        private List<PlayerData> leaderboardData = new List<PlayerData>(); // List to store player data
        private string filePath; // File path where leaderboard data is saved





        //-------------------------------------------END OF VARIABLES----------------------------------------------------------------//




        public LeaderBoard(string filePath)
        {
            this.filePath = filePath;
            LoadLeaderboardData();
        }



        public void SavePlayerData(string playerName, int elapsedTimeInSeconds)
        {

            PlayerData player = new PlayerData
            {
                PlayerName = playerName,
                ElapsedTimeInSeconds = elapsedTimeInSeconds
            };


            leaderboardData.Add(player);


            SaveLeaderboardData();
        }

        public List<PlayerData> GetLeaderboardData()
        {

            return leaderboardData;
        }

        private void SaveLeaderboardData()
        {
            // Serialize and save the leaderboard data to the specified file
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, leaderboardData);
            }
        }

        private void LoadLeaderboardData()
        {

            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    leaderboardData = (List<PlayerData>)formatter.Deserialize(stream);
                }
            }
        }

        // private string fullFilePath;


        /*
        public LeaderBoard(string fullFilePath)
        {
            this.fullFilePath = fullFilePath;
        }
        */
    }
}
