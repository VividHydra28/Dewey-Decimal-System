using PROG7312_POE.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PROG7312_POE.SubForms
{
    public partial class FIndingCallNumbers_UserControl : UserControl
    {
        private const string Caption = "Enjoy your existence ";
        CallNumbersCategories c = new CallNumbersCategories();
        public string UserName;
        public string UserDescription;
        public bool CanReturn = true;
        int QuestionCount = 0;
        public string MessagePrompt;
        int streak;
        CallNumbersCategories q;
        CallNumbersCategories a;

        List<CallNumbersCategories> TreeValues;


        //-------------------------------------------------------------------END OF VARIABLES------------------------------------------//

        public FIndingCallNumbers_UserControl()
        {
            InitializeComponent();

            toolTipHelp.SetToolTip(UserName_txt, "Enter your username here.");
        }

        private void FIndingCallNumbers_UserControl_Load(object sender, EventArgs e)
        {

        }

        public void PopulateValues()
        {
            AnswerBox.Items.Clear();

            if (QuestionCount == 0)
            {
                TreeValues = c.GetRandomQA();

                if (TreeValues != null && TreeValues.Count > 0)// Check if TreeValues is not null and has elements before accessing its elements
                {
                    QuestionBox.Text = TreeValues.ElementAtOrDefault(0)?.Name;// Display description

                    for (int i = 1; i < 5 && i < TreeValues.Count; i++)// Display exactly 4 items
                    {
                        string itemText = TreeValues.ElementAtOrDefault(i)?.ToString();
                        if (itemText != null)
                        {
                            AnswerBox.Items.Add(itemText);
                        }
                    }
                }

                /*   QuestionBox.Text = TreeValues.ElementAt(0).Name;

                   for (int i = 1; i < 5; i++)
                   {
                       AnswerBox.Items.Add(TreeValues.ElementAt(i).ToString());
                   }

                   */
                QuestionCount++;
            }

            else
            {
                if (TreeValues != null)// Check if TreeValues is not null before accessing its elements
                {
                    for (int i = 5; i < TreeValues.Count; i++)// Display all items starting from index 5
                    {
                        string itemText = TreeValues.ElementAtOrDefault(i)?.ToString();
                        if (itemText != null)
                        {
                            AnswerBox.Items.Add(itemText);
                        }
                    }
                }

                QuestionCount--;
            }

            /*

            else
            {
                for (int i = 5; i < TreeValues.Count; i++)
                {
                    AnswerBox.Items.Add(TreeValues.ElementAt(i).ToString());
                }

                QuestionCount--;
            }
            */
        }

        public bool CheckAnswer()
        {
            q = TreeValues.ElementAt(0);
            if (QuestionCount == 1)
            {
                a = TreeValues.ElementAt(AnswerBox.SelectedIndex + 1);
                MessagePrompt = c.CheckAnswerTopLevel(a, q).message; // Appropriate response according to result.

                return c.CheckAnswerTopLevel(a, q).correct;
            }
            else
            {
                a = TreeValues.ElementAt(AnswerBox.SelectedIndex + 5);
                MessagePrompt = c.CheckAnswerSecondLevel(a, q).message;

                return c.CheckAnswerSecondLevel(a, q).correct;
            }
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {

            Finish_btn.Enabled = false; // User must not be able to click the finish button mid game.
            UserName = UserName_txt.Text.Trim();
            if (UserName.Equals(""))
            {
                MessageBox.Show("Please enter your username!", "Alert");
            }
            else
            {
                QuestionCount = 0;
                streak = 0;
                PopulateValues();
                CanReturn = false; // User cannot go back to the menu mid game.
                UserName_txt.Enabled = false;
                StartBtn.Enabled = false;
                Finish_btn.Enabled = true;
            }
        }

        /*
        public void HandleScores()
        {
            FindingCallNumbersScores scores = new FindingCallNumbersScores(streak, userName);
            List<FindingCallNumbersScores> listScores = scores.ReadHighScores();

            if (scores.IsScoreHigher(listScores, scores))
            {
                scores.UpdateLeaderboard(listScores, scores);
                MessageBox.Show($"Congratulations, {UserName}, you achieved a highscore with a streak of {streak}!", "YAY");
                MessageBox.Show(scores.DisplayHighScores(), "High Scores");
            }
            else
            {
                MessageBox.Show("Unfortunately you did not achieve a high score! Please try again.", ":(");
            }

            streak = 0;
        }
        */

        private void btnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing!", Caption);

            // HandleScores();
            Housekeeping();
            CanReturn = true;
            QuestionCount = 0;
        }

        public void Housekeeping()
        {
            AnswerBox.Items.Clear();
            UserName_txt.Clear();
            QuestionBox.Clear();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            if (AnswerBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an answer!");
            }
            else
            {
                if (CheckAnswer())
                {
                    MessageBox.Show(MessagePrompt, "Congratulations!");

                    if (QuestionCount == 0)
                    {
                        streak++;
                    }
                    PopulateValues(); // Filling in the questions.
                }
                else
                {
                    MessageBox.Show($"{MessagePrompt}\nThank you for playing! Click restart to go again.", ":(");

                    // HandleScores();
                    AnswerBox.Items.Clear();
                    StartBtn.Text = "Restart";
                    CanReturn = true;
                    UserName_txt.Enabled = true;
                    StartBtn.Enabled = true;
                    Housekeeping();
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            FindingCallNumbers_Form form = new FindingCallNumbers_Form();
            if (CanReturn)
            {
                form.Close();
            }
            else
            {
                MessageBox.Show("Please finish the game before returning to the menu!", "Alert");
            }
        }


    }
}

//--------------------------------------------------------------------------------------END OF CODE---------------------------------------------//
