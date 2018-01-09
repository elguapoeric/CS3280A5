using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet5
{
    public class UserInfo
    {
        /// <summary>
        /// Users first name
        /// </summary>
        private string name;
        /// <summary>
        /// Users last name
        /// </summary>
        private string lastname;
        /// <summary>
        /// Users age
        /// </summary>
        private int age;
        /// <summary>
        /// hours 
        /// </summary>
        private int hours;
        /// <summary>
        /// minutes
        /// </summary>
        private int minutes;
        /// <summary>
        /// seconds
        /// </summary>
        private int seconds;
        /// <summary>
        /// number of correct answers
        /// </summary>
        private int correct;
        /// <summary>
        /// number of incorrect answers
        /// </summary>
        private int incorrect;
        /// <summary>
        /// initializes class 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="l"></param>
        /// <param name="a"></param>
        /// <param name="c"></param>
        /// <param name="i"></param>
        /// <param name="h"></param>
        /// <param name="min"></param>
        /// <param name="s"></param>
        public UserInfo(string n, string l, int a, int c, int i, int h = 0, int min = 0, int s = 0)
        {
            this.name = n;
            this.lastname = l;
            this.age = a;
            this.hours = h;
            this.minutes = min;
            this.seconds = s;
            this.correct = c;
            this.incorrect = i;
        }
        /// <summary>
        /// get set name 
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// get set age
        /// </summary>

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// get set last name
        /// </summary>
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        /// <summary>
        /// get set hours
        /// </summary>
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        /// <summary>
        /// get set minutes
        /// </summary>
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        /// <summary>
        /// get set seconds
        /// </summary>
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        /// <summary>
        /// get set number of correct answers
        /// </summary>
        public int Correct
        {
            get { return correct;}
            set { correct = value; }
        }
        /// <summary>
        /// get set number of incorrect answers
        /// </summary>
        public int Incorrect
        {
            get { return incorrect; }
            set { incorrect = value; }
        }

     
    }
}
