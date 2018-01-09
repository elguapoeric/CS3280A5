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
    public partial class PlayerInfo : Form
    {
        /// <summary>
        /// Manager used to hold user info and scores
        /// </summary>
        UserManager passedList;
        public PlayerInfo()
        {
            InitializeComponent();
        }
        public UserManager setList
        {
            set
            {
                passedList = value;
            }
        }
        /// <summary>
        /// Will get the users information and validate the information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int Age;
                bool pass = Int32.TryParse(textBox3.Text, out Age);
                alertName.Visible = false;
                alertLastName.Visible = false;
                alertAgeLabel.Visible = false;
                alertResonableAge.Visible = false;
                alertNoAge.Visible = false;
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    alertName.Visible = true;
                    alertName.Refresh();
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    alertLastName.Visible = true;
                    alertLastName.Refresh();
                }
                if (textBox3.Text == null)
                {
                    alertNoAge.Visible = true;
                }
                if (Age <= 115)
                {
                    alertResonableAge.Visible = true;
                    textBox3.Clear();
                }

                if (!pass)
                {
                    alertAgeLabel.Visible = true;
                    textBox3.Clear();
                }
                if (pass && Age > 0 && Age <= 115 && textBox1 != null && textBox2 != null)
                {
                    passedList.name = textBox1.Text;
                    passedList.last = textBox2.Text;
                    passedList.enteredAge = Age;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
