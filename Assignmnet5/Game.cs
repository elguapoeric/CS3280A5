using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;


using System.Windows.Forms;

namespace Assignmnet5
{
    public partial class Game : Form
    {
        /// <summary>
        /// The acutal game that will be played
        /// </summary>
        MathGame theGame;
        /// <summary>
        /// Class that create will hold  user scores
        /// </summary>
        UserManager passedListPartFill;
        /// <summary>
        /// Used to show the user if they got the right answer
        /// </summary>
        string correctIncorrect = "Correct/Incorrect\n";
        /// <summary>
        /// Used to create a timer for the user to see
        /// </summary>
        Timer gameTimer;
        /// <summary>
        /// represent hours
        /// </summary>
        int h = 0;
        /// <summary>
        /// represents minutes
        /// </summary>
        int m = 0;
        /// <summary>
        /// represents seconds
        /// </summary>
        int s = 0;

        public Game()
        {
            InitializeComponent();
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            
        }
        /// <summary>
        /// Allows for passing in UserManger in the MainMenu
        /// </summary>
        public UserManager setList
        {
            set
            {
                passedListPartFill = value;
            }
        }

        /// <summary>
        /// This method will increment the time every second and will display it to the user in hh:mm:ss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //if statements to change 60 seconds to a minute and 60 mintutes to an hour
                s++;
                if (s == 60) 
                {
                    s = 0;
                    m++;
                }
                if (m == 60)
                {
                    m = 0;
                    h++;
                }
                //will display the time hh:mm:ss
                labelTimer.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
                labelTimer.Refresh();
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
           
        }

      
        /// <summary>
        /// Will keep track of number of correct answers and will determine when to stop the timer and end the game.
        /// Also provides the user with a new equation to solve.
        /// </summary>
        private void setEqButtons()
        {
            try
            {
                //Will display the question number at the top 
                if (theGame.getCount() <= 9)
                {
                    label2.Text = (theGame.getCount() + 1).ToString();
                    label2.Refresh();
                }
                //Checks if user is answer is correct and increment a correct answers in class and show a new equation to solve
                if (theGame.checkSolution(equationLabel.Text, userAnswer.Text))
                {
                    theGame.incrementCorrect();
                    if (theGame.getCount() >= 1 && theGame.getCount() <= 11)
                    {
                        correctIncorrect += (theGame.getCount()).ToString() + ". Correct\n ";
                        label4.Text = correctIncorrect;
                        if (theGame.getCount() < 10)
                        {
                            equationLabel.Text = theGame.getEquation();
                        }
                    }

                    userAnswer.Clear();
                    Refresh();
                }
                //if user answer is incorrect increment incorrect answers in class and show a new equation to solve
                else
                {
                    if (theGame.getCount() >= 1 && theGame.getCount() <= 11)
                    {
                        theGame.incrementIncorrect();
                        correctIncorrect += (theGame.getCount()).ToString() + ". Incorrect\n ";
                        label4.Text = correctIncorrect;
                        if (theGame.getCount() < 10)
                        {
                            equationLabel.Text = theGame.getEquation();
                        }
                    }
                    userAnswer.Clear();
                    Refresh();

                }
                //checks to see if the user has gotten ten questions if so stop the timer and add  user info, score and time to UserManager
                if (theGame.getCorrect() + theGame.getIncorrect() == 10)
                {
                    gameTimer.Stop();
                    passedListPartFill.AddNewUser(passedListPartFill.name, passedListPartFill.last, passedListPartFill.enteredAge, theGame.getCorrect(), theGame.getIncorrect(), h, m, s);
                    this.Hide();
                    Scores ShowScores = new Scores();
                    ShowScores.setList = passedListPartFill;
                    ShowScores.showScores();
                    ShowScores.ShowDialog();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
        
        /// <summary>
        /// When user presses enter key will check solution and increment the number of correct or incorrect answers
        /// then provide a new question for the user and clear the textbox as well as stop the timer and end the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    setEqButtons();
                    e.Handled = true;
                    e.SuppressKeyPress = true; //get rid of windows alert sound when user presses enter
                }
            }
            catch(Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// When user click enter button will check solution and increment the number of correct or incorrect answers
        /// then provide a new question for the user and clear the textbox as well as stop the timer and end the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                setEqButtons();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// Will create a new game based on the radio button selected by the user and start the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    theGame = new Assignmnet5.MathGame(1);
                }
                else if (radioButton2.Checked)
                {
                    theGame = new Assignmnet5.MathGame(2);
                }
                else if (radioButton3.Checked)
                {
                    theGame = new Assignmnet5.MathGame(3);
                }
                else if (radioButton4.Checked)
                {
                    theGame = new Assignmnet5.MathGame(4);
                }
                equationLabel.Text = theGame.getEquation();
                equationLabel.Visible = true;
                userAnswer.Clear();
                userAnswer.Visible = true;
                enterButton.Visible = true;
                RadioButtonsBox.Enabled = false;
                gameTimer.Start();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handle Error
        /// </summary>
        /// <param name="sClass">The class in which error occured in</param>
        /// <param name="sMethod">The method in which the error occured in</param>
        /// <param name="sMessage">The message that is thrown</param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " ->" + sMessage);
            }
            catch(Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                              "HandleError Exception: " + ex.Message);
            }
        }
    
    }
}
