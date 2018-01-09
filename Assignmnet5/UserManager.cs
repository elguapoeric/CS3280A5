using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Assignmnet5
{
    /// <summary>
    /// This class creates a List of UserInfo objects 
    /// </summary>
    public class UserManager
    {
        /// <summary>
        /// List of of UserInfo object used to store multiple users and their information
        /// </summary>
        public static List<UserInfo> userList { get; set; }
        /// <summary>
        /// used to store name temporarly 
        /// </summary>
        public string name;
        /// <summary>
        /// used to store last name temporarly 
        /// </summary>
        public string last;
        /// <summary>
        /// used to store age temporarly 
        /// </summary>
        public int enteredAge = 0;
       
        /// <summary>
        /// creating a List of UserInfo objects
        /// </summary>
        public UserManager()
        {
            userList = new List<UserInfo>();
        }
        /// <summary>
        /// This method allows for adding a users personal information and gaming stats to the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="Age"></param>
        /// <param name="Correct"></param>
        /// <param name="Incorrect"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void AddNewUser(string firstName, string lastName, int Age, int Correct, int Incorrect, int hours, int minutes, int seconds)
        {
            try
            {
                userList.Add(new UserInfo(firstName, lastName, Age, Correct, Incorrect, hours, minutes, seconds));
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        public UserInfo getLast()
        {
            try
            {
                int var = userList.Count;
                return userList[var - 1];
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}