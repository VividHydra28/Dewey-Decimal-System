using PROG7312_POE.ReplaceBooks_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE.SubForms
{
    public partial class ReplaceBooks_UserControl : UserControl
    {


        UserInputBox_class userInputBox_Class = new UserInputBox_class();

        private List<string> generatedCallNumbers;
        private List<string> originalCallNumbers; // To store the original order
        public NumberCallLogic callNumberLogic = new NumberCallLogic();



        private bool timerRunning = false;
        private int elapsedTimeInSeconds = 0;
        private bool isMovingCallNumber = false; // Indicates whether the user is currently moving a call number

        private bool isOrderCorrect = false;

        private DateTime timerStopTime;

        private LeaderBoard leaderboard;




        public ReplaceBooks_UserControl()
        {
            InitializeComponent();


            TimerClock.Tick += timer_Tick;


            User_Display_Timer.Text = "Elapsed Time: 0:00:00";


            string currentDirectory = Environment.CurrentDirectory;

            //This code defines the relative file path for the leaderboard data
            string relativeFilePath = "LeaderboardPlayerData.dat";



            string fullFilePath = Path.Combine(currentDirectory, relativeFilePath);

            //This line of code created an instance of the Leaderboard class with the appropriate file path
             leaderboard = new LeaderBoard(fullFilePath);

        }

        private void BookShelf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubMenu_btn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            //Show the MainForm to make it visible
            mainForm.Show();
        }

        private void Generate_Numbers_Btn_Click(object sender, EventArgs e)
        {
            //This line of code calls the GenerateCall
            generatedCallNumbers = callNumberLogic.GenerateCallNumbers();


            originalCallNumbers = new List<string>(generatedCallNumbers);


            BookShelf.Items.Clear();
            foreach (string callNumber in generatedCallNumbers)
            {
                BookShelf.Items.Add(callNumber); // Each call number will be on a new line
            }
        }

        private void User_Display_Timer_Click(object sender, EventArgs e)
        {

        }

        private void MoveUp_btn_Logic()
        {
            if (BookShelf.SelectedIndex == -1)
            {
                MessageBox.Show("No call number has been selected, please select one to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = BookShelf.SelectedIndex;

            if (selectedIndex > 0)
            {
                string selectedItem = BookShelf.SelectedItem.ToString();
                BookShelf.Items.RemoveAt(selectedIndex);
                BookShelf.Items.Insert(selectedIndex - 1, selectedItem);
                BookShelf.SelectedIndex = selectedIndex - 1;


                if (!isMovingCallNumber)  // This code will start or restart the timer when the user starts moving a call number
                {
                    StartTimer();
                    isMovingCallNumber = true;
                }
            }
            else
            {

                StopTimer();
                isMovingCallNumber = false;
            }
        }

        private void Move_Down_btn_logic()
        {
            if (BookShelf.SelectedIndex == -1)
            {
                MessageBox.Show("No call number has been selected, please select one to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = BookShelf.SelectedIndex;

            if (selectedIndex < BookShelf.Items.Count - 1 && selectedIndex != -1)
            {
                string selectedItem = BookShelf.SelectedItem.ToString();
                BookShelf.Items.RemoveAt(selectedIndex);
                BookShelf.Items.Insert(selectedIndex + 1, selectedItem);
                BookShelf.SelectedIndex = selectedIndex + 1;


                if (!isMovingCallNumber)
                {
                    StartTimer();
                    isMovingCallNumber = true;
                }
            }
            else
            {

                StopTimer();


                isMovingCallNumber = false;
            }
        }

        private void Check_Order_Click(object sender, EventArgs e)
        {
            if (isMovingCallNumber)
            {
                StopTimer();
                isMovingCallNumber = false;
            }




            // The rest of your existing code for checking the order goes here
            List<string> currentOrder = BookShelf.Items.Cast<string>().ToList();
            QuickSort(currentOrder, 0, currentOrder.Count - 1);

            if (currentOrder.SequenceEqual(BookShelf.Items.Cast<string>()))
            {
                isOrderCorrect = true;
                MessageBox.Show("Order is correct! Enter your name for the leaderboard.");





                string playerName = PromptForName();

                // Call the SavePlayerData method on the leaderboard instance with the correct elapsed time
                //   leaderboard.SavePlayerData(playerName, elapsedTimeInSeconds);
            }
            else
            {
                isOrderCorrect = false;
                MessageBox.Show("Game Over. Order is incorrect!");

                // Clear the ListBox and reset the timer
                BookShelf.Items.Clear();
                // Reset the timer and elapsed time
                ResetTimer();
            }
        }

        private string PromptForName()
        {

            string playerName = "";
            UserInputBox_class.ShowDialog("Enter your name:", "Leaderboard Entry", ref playerName);
            return playerName;
        }

        private void QuickSort(List<string> list, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(list, low, high);

                QuickSort(list, low, partitionIndex - 1);
                QuickSort(list, partitionIndex + 1, high);
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (timerRunning)
            {
                TimeSpan elapsedTime = DateTime.Now - timerStopTime;
                elapsedTimeInSeconds = (int)elapsedTime.TotalSeconds;


                User_Display_Timer.Text = "Elapsed Time: " + elapsedTime.ToString(@"hh\:mm\:ss"); //This line of code updates the timer
            }
        }


        private void StartTimer()
        {
            timerRunning = true;
            TimerClock.Start();
            timerStopTime = DateTime.Now; // Set the timer stop time to the current time
        }



        private void ResetTimer()
        {
            StopTimer(); // Stop the timer
            elapsedTimeInSeconds = 0; // Reset elapsed time to 0
            User_Display_Timer.Text = "Elapsed Time: 0:00:00"; // Update the label
        }


        private void StopTimer()
        {
            if (timerRunning)
            {
                timerRunning = false;
                TimerClock.Stop();


                TimeSpan elapsedTime = DateTime.Now - timerStopTime;


                elapsedTimeInSeconds = (int)elapsedTime.TotalSeconds;


                User_Display_Timer.Text = "Elapsed Time: " + elapsedTime.ToString(@"hh\:mm\:ss");
            }
        }


        private int Partition(List<string> list, int low, int high)
        {
            string pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (string.Compare(list[j], pivot) <= 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }


        //This methid is used to swap the elements
        private void Swap(List<string> list, int i, int j)
        {
            string temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }


        private void Move_Down_Btn_Click(object sender, EventArgs e)
        {
            Move_Down_btn_logic();
        }

        private void Move_Up_btn_Click(object sender, EventArgs e)
        {
            MoveUp_btn_Logic();
        }

        private void ReplaceBooks_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
