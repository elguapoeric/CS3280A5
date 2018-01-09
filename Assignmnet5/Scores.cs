using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmnet5
{
    public partial class Scores : Form
    {

        /// <summary>
        /// Stores user info and user game stats
        /// </summary>
        UserManager passedList;
        public Scores()
        {
           
            InitializeComponent();
        }
        /// <summary>
        /// allows to pass in UserManager from main menu
        /// </summary>
        public UserManager setList
        {
            set
            {
                passedList = value;
            }
        }

        public void showScores()
        {
            try
            {
                UserInfo info = passedList.getLast();
                label3.Text = info.Name + info.LastName;
                label8.Text = info.Age.ToString();
                label2.Text = info.Correct.ToString();
                label5.Text = String.Format("{0:00}:{1:00}:{2:00}", info.Hours, info.Minutes, info.Seconds);
                if (info.Correct <= 7)
                {
                    label4.Text = "Study Harder";
                    this.BackgroundImage = global::Assignmnet5.Properties.Resources.Sad;
                    /*
                    SoundPlayer simpleSound = new SoundPlayer("boo.wav");
                    simpleSound.Play();*/
                    SoundPlayer audio = new SoundPlayer(global::Assignmnet5.Properties.Resources.boo); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                    audio.Play();




                }
                if (info.Correct > 7)
                {
                    label4.Text = "Good Job!";
                    this.BackgroundImage = global::Assignmnet5.Properties.Resources.Happy;
                    /*SoundPlayer simpleSound = new SoundPlayer("cheer.wav");
                    simpleSound.Play();*/
                    SoundPlayer audio = new SoundPlayer(global::Assignmnet5.Properties.Resources.cheer);
                    audio.Play();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
            
    }
}
