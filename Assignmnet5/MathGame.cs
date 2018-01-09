using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace Assignmnet5
{   

    /// <summary>
    /// Creates random math equations of + - * / and checks the solution
    /// </summary>
    class MathGame
    {
        /// <summary>
        /// random variable for equation
        /// </summary>
        private int var1;
        /// <summary>
        /// random variable for equation
        /// </summary>
        private int var2;
        /// <summary>
        /// random generator to get numbers for var 1 and var2
        /// </summary>
        Random gen = new Random();
        /// <summary>
        /// used to store equations
        /// </summary>
        private string[] equations  = new string[10];
        /// <summary>
        /// holds the number of times answers were correct
        /// </summary>
        private int correctAnswers;
        /// <summary>
        /// holds the number of times answers were incorrect
        /// </summary>
        private int incorrectAnswers;
        /// <summary>
        /// counts used to move through elements
        /// </summary>
        private int count = 0;

        /// <summary>
        /// set correct incorrect answers to zero since new game is being started
        /// </summary>
        /// <param name="i"></param>
        public MathGame(int i)
        {
            correctAnswers = 0;
            incorrectAnswers = 0;
            populate(i);

        }
        /// <summary>
        /// creates an addition equation
        /// </summary>
        /// <returns></returns>
        public string addition()
        {
            try
            {
                var1 = gen.Next(0, 20);
                var2 = gen.Next(0, 20);

                return var1.ToString() + " + " + var2.ToString() + " = ";
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// creates a subraction equation
        /// </summary>
        /// <returns></returns>
        public string subtraction()
        {
            try
            {
                var1 = gen.Next(0, 20);
                var2 = gen.Next(0, 10);
                while (var1 <= var2)
                {
                    var1 = gen.Next(0, 20);
                }
                return var1.ToString() + " - " + var2.ToString() + " = ";
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
           
        }
        /// <summary>
        /// creates a multiplication equation
        /// </summary>
        /// <returns></returns>
        public string multiplication()
        {
            try
            {
                var1 = gen.Next(0, 10);
                var2 = gen.Next(0, 10);

                return var1.ToString() + " * " + var2.ToString() + " = ";
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

           
        }

        /// <summary>
        /// creates a division equation
        /// </summary>
        /// <returns></returns>
        public string division()
        {
            try
            {
                var1 = gen.Next(0, 20);
                var2 = gen.Next(1, 20);

                while (var1 < var2)
                {
                    var1 = gen.Next(1, 20);
                }
                while (var1 % var2 != 0)
                {
                    var2 = gen.Next(1, 20);
                }
                return var1.ToString() + " / " + var2.ToString() + " =";
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
           
        }
        /// <summary>
        /// will parse an equation of type var1 (+, -, /, *) var2 and solve it
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int solve(string s)
        {
            try
            {
                string mathExprs = s;
                string[] splitExp = s.Split(' ');
                int a = Convert.ToInt32(splitExp[0]);
                int b = Convert.ToInt32(splitExp[2]);
                string oper = splitExp[1];

                if (oper == "+")
                {
                    return a + b;
                }
                if (oper == "-")
                {
                    return a - b;
                }
                if (oper == "/")
                {
                    return a / b;
                }
                if (oper == "*")
                {
                    return a * b;
                }
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            //split the string and store it in an array element 1 will contain the operator 
           

        }
        /// <summary>
        /// populate an array with equations 
        /// </summary>
        /// <param name="a"></param>
        public void populate(int a)
        {
            if(a == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    equations[i] = addition();
                }
            }
            if(a == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    equations[i] = subtraction();
                }
            }
            if(a == 3)
            {
                for (int i = 0; i < 10; i++)
                {
                    equations[i] = multiplication();
                }
            }
            if(a == 4) {
                for (int i = 0; i<10; i++)
                {
                    equations[i] = division();
                }
            }
        }

        /// <summary>
        /// returns user an equation
        /// </summary>
        /// <returns></returns>
        public string getEquation()
        {
            return equations[count++];
        }

        /// <summary>
        /// checks solution 
        /// </summary>
        /// <param name="s">equation as string</param>
        /// <param name="userAnswer">answer as string</param>
        /// <returns></returns>
        public Boolean checkSolution(string s, string userAnswer)
        {
            int answer = -1;
            bool checkParse = Int32.TryParse(userAnswer, out answer);

            if (checkParse)
            {
                if (solve(s) == answer)
                {
                    
                    return true;
                }
            }
               
            return false;
        }
        /// <summary>
        /// return count
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            return count;
        }
        /// <summary>
        /// returns correctanswers
        /// </summary>
        /// <returns></returns>
        public int getCorrect()
        {
            return correctAnswers;
        }
        /// <summary>
        /// returns incorrect answers
        /// </summary>
        /// <returns></returns>
        public int getIncorrect()
        {
            return incorrectAnswers;
        }
        /// <summary>
        /// increments correct answers
        /// </summary>
        public void incrementCorrect()
        {
            correctAnswers++;
        }
        /// <summary>
        /// increments correct answers
        /// </summary>
        public void incrementIncorrect()
        {
            incorrectAnswers++;
        }



    }
}
