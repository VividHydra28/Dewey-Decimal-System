using PROG7312_POE.Forms;
using PROG7312_POE.IdentifyingAreas.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE.SubForms
{
    public partial class IdentifyingAreas_control : UserControl
    {

        private JsonFileData json = new JsonFileData();

        private Dictionary<string, string> NumberDescriptionDictionary;
        private Dictionary<string, string> UserChoice = new Dictionary<string, string>();

        public int playerpoints = 0;

        private bool matchingCallNumbersToDescriptions = true; // Initial question type is matching call numbers to descriptions

        DateTime startTime;

        TimeSpan maxTime = TimeSpan.FromMinutes(3);  //This variable sets the time limit for the game
        TimeSpan elapsedTime;




        // Variables for timer
        private bool timerRunning = false;
        private DateTime timerStopTime;
        private int elapsedTimeInSeconds = 0;



        //-----------------------------------------------------------------END OF VARIABLES----------------------------------------------//




        public IdentifyingAreas_control()
        {
            InitializeComponent();


            MessageBox.Show("Welcome tp this part of the application \n" +
              "Here are the correct game answers. GOOD LUCK\n" +
              "000 -General Knowledge \n" +
              "100 - Philosophy & Psychology \n" +
              "200 - Religion \n" +
              "300 - Social Sciences \n" +
              "400 - Language \n" +
              "500 - Science \n" +
              "600 - Technology (Applied Sciences \n" +
              "700 - The Arts \n" +
              "800 - Literature \n" +
              "900 - Geography & History \n", "How to play ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActivateData();

            if (!JsonFileData.CallNumFileExists()) { JsonFileData.CreateCallNumFile(); }

            ActivateQuestions();

        }

        public void ActivateQuestions()
        {

            StartTimer();

            //These two lines of code clears both boxes
            ListBoxNum.Items.Clear();
            ListBoxDesc.Items.Clear();

            var random = new Random();
            var selectedCallNumbers = NumberDescriptionDictionary.Keys.OrderBy(x => random.Next()).Take(4).ToList();



            foreach (var callNumber in selectedCallNumbers)
            {
                ListBoxNum.Items.Add(callNumber);
            }

            //These two lines of code generate the descriptions
            var descriptions = new List<string>();
            var correctDescriptions = new List<string>();

            foreach (var callNumber in selectedCallNumbers)
            {
                correctDescriptions.Add(NumberDescriptionDictionary[callNumber]);
            }


            while (descriptions.Count < 3)
            {
                var randomDescription = NumberDescriptionDictionary.Values.OrderBy(x => random.Next()).First();
                if (!correctDescriptions.Contains(randomDescription) && !descriptions.Contains(randomDescription))
                {
                    descriptions.Add(randomDescription);
                }
            }


            descriptions.Add(correctDescriptions[0]);
            descriptions.Add(correctDescriptions[1]);
            descriptions.Add(correctDescriptions[2]);
            descriptions.Add(correctDescriptions[3]);

            //Shuffle the list of descriptions.
            // descriptions = descriptions.OrderBy(x => random.Next()).ToList();


            if (matchingCallNumbersToDescriptions)
            {
                foreach (var description in descriptions)
                {
                    ListBoxDesc.Items.Add(description);
                }
            }
            else
            {
                foreach (var description in descriptions)
                {
                    ListBoxNum.Items.Add(description);
                }
            }
        }


        public void ActivateData()
        {
            //StartTimer();
           // JsonFileData.GetKeyValuePairs();

            NumberDescriptionDictionary = new Dictionary<string, string>
            {
                { "000", "General Knowledge" },
                { "100", "Philosophy and Psychology" },
                { "200", "Religion" },
                { "300", "Social Sciences" },
                { "400", "Languages" },
                { "500", "Natural Sciences & Mathematics" },
                { "600", "Technology (Applied Sciences)" },
                { "700", "The Arts" },
                { "800", "Literature & Rhetoric" },
                { "900", "Geography & History" }
            };

        }


        private void IdentifyingAreas_control_Load(object sender, EventArgs e)
        {

        }

        private void StopTimer()
        {
            timerRunning = false;
            timer1.Stop();
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.ShowDialog();
            IdentifyingAreas_Form frm = new IdentifyingAreas_Form();
            frm.Close();
        }

        private void PlayerScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            string callNumber;
            string description;

            if (ListBoxNum.SelectedItem != null && ListBoxDesc.SelectedItem != null)
            {
                callNumber = ListBoxNum.SelectedItem.ToString();
                description = ListBoxDesc.SelectedItem.ToString();


                UserChoice[callNumber] = description;

                //These two lines of code remove the selected items from the list boxes.
                ListBoxNum.Items.Remove(callNumber);
                ListBoxDesc.Items.Remove(description);


                if (UserChoice.Count == 1)
                {
                    startTime = DateTime.Now;
                }
            }
        }

        private void Social_btn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void PlayerScoreNum_Click(object sender, EventArgs e)
        {

        }

        private void NextQuestionbtn_Click(object sender, EventArgs e)
        {
            ResetGame();

            StartTimer();
        }

        private void Check_Answerbtn_Click(object sender, EventArgs e)
        {

            StopTimer();


            elapsedTime = TimeSpan.FromSeconds(elapsedTimeInSeconds);

            //The two lines of code are meant for player points
            int correctCount = 0;
            int totalQuestions = UserChoice.Count;

            foreach (var userSelection in UserChoice)
            {
                string callNumber = userSelection.Key;
                string userDescription = userSelection.Value;

                if (NumberDescriptionDictionary.TryGetValue(callNumber, out string correctDescription))
                {
                    if (correctDescription == userDescription)
                    {
                        correctCount++;
                    }
                }
            }

            ResetGame();
        }

        private void labelDisplayTimer_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartTimer()
        {
            timerRunning = true;
            timerStopTime = DateTime.Now;
            timer1.Start();
        }


        private void ClearSelectedItems()
        {
            ListBoxNum.ClearSelected();
            ListBoxDesc.ClearSelected();
        }


        public void ResetGame()
        {
            ClearSelectedItems();

            //PlayerScoreNum.ToString("0");
            UserChoice.Clear();
            playerpoints = 0;
            elapsedTimeInSeconds = 0;
            ListBoxNum.Items.Clear();
            ListBoxDesc.Items.Clear();
            ActivateQuestions();
            StartTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerRunning)
            {
                TimeSpan elapsedTime = DateTime.Now - timerStopTime;


                elapsedTimeInSeconds = (int)elapsedTime.TotalSeconds;


                labelDisplayTimer.Text = "Elapsed Time: " + elapsedTime.ToString(@"hh\:mm\:ss");
            }
        }
    }
}


//------------------------------------------------------------------------END OF CODE----------------------------------------------------------//