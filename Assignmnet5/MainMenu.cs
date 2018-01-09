using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmnet5
{
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Class used to store user info and scores and time
        /// </summary>
        UserManager userList;

        /// <summary>
        /// creates usermanager which will be used throughout various windows
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            userList = new UserManager();
        }
        /// <summary>
        /// Launches game only after having at least one user enter there information and passed validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGame_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Game gameMenu = new Game();
                gameMenu.setList = userList;
                gameMenu.ShowDialog();
                this.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Launches page for user to enter their information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void UserData_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PlayerInfo fillInfo = new PlayerInfo();
                fillInfo.setList = userList;
                fillInfo.ShowDialog();
                this.Show();
                if (userList.name != null && userList.last != null && userList.enteredAge != 0)
                {
                    PlayGame.Enabled = true;
                    PlayGame.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// changes Enterinfo button text color to green when mouse is over button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserData_MouseHover(object sender, EventArgs e)
        {
            try
            {
                UserData.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// changes Enterinfo button to black when user moves mouse off button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserData_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                UserData.ForeColor = Color.Black;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// changes Playgame button text color to green when mouse if over button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGame_MouseHover(object sender, EventArgs e)
        {
            try
            {
                PlayGame.ForeColor = Color.Green;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// changes  Playgame button to black when user moves mouse off button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGame_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                PlayGame.ForeColor = Color.Black;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
