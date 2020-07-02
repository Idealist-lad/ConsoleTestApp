using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lecturer;
using ProgAssign2.test;

namespace ProgAssign2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variables
            //-nongeneric
            //holds Question, a, b, c, ans 
            ArrayList testData = new ArrayList();

            //holds ans for Q1, Q2, Q3
            ArrayList userData = new ArrayList();

            //-generic                                     
            List<string> memo = new List<string>();
            
            // Creating Class object
            
            dynamic TLecturer = new Class1();
            dynamic TStudent = new Student();
            



            //Calling Methods
            welcomeMessage();
            instructions1();
            //Test topic will be called by this paper object 
            //the lecturer will be requested to entr the topic of the test
            Paper TPaper = new Paper();

            //PROCESS
            testData.AddRange(convertToArrayList(TLecturer.setTest()));
            instructions2();
            userData.AddRange(TStudent.takeTest(testData));

            // Output message after the test 
            memo = convertToList(TLecturer.getCorrectAns(), TStudent.getUserAnswer());
            generateMemo(memo);
           
            Console.WriteLine("\n\n\tThis is what you managed to get on your test {0}/3 Hope you're proud of yourself\n\nThank you for using"
                            + " this app. Press Enter Key to exit...", TPaper.calculateScore(testData, userData));
            Console.ReadLine();

        }
        /*Greeting method before the test begins*/
        public static void welcomeMessage()
        {
            String border = "\n+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+#+\n";
            Console.WriteLine("Welcome to the Multiple Choice Test Application where you'll have"
                + "\n  an opportunity to be both the lecturer student.\n\tClick Enter key to continue..." + border + border);
            Console.ReadLine();
        }
        //instructons method --this is for the lecturer
        //for setting up a test
        public static void instructions1() 
        {
            String border = "\n**********************************************************************************\n";
            Console.Clear();
            Console.WriteLine(border + "You are the lecturer, set a test composed of three questions.\nEach question will have"
                + " 3 options and a correct answer.\n\tClick Enter to continue..." + border);
            Console.ReadLine();
        }
        //Unstruction method --for student when taking the test
        //for taking a test
        public static void instructions2() 
        {
            String border = "\n*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>*\n";
            Console.Clear();
            Console.WriteLine(border + "Now, as a student, take the test set by the lecturer...\n enter only the "
                + "correct letter and click Enter to continue\n" + border);
            Console.ReadLine();
        }

        public static void generateMemo(List<string> sList)
        {
            Console.Write("\n\t\t** MEMO **\nQuestion 1|\tCorrect answer: {0}\tYour answer: {1}"
                            + "\nQuestion 2|\tCorrect answer: {2}\tYour answer: {3}\nQuestion 3|\t"
                            + "Correct answer: {4}\tYour answer: {5}\n", sList[0], sList[3], sList[1], sList[4], sList[2], sList[5]);
        }
        //Counts the marks for the student while taking the test--Method
        public static string[] convertToArrayList(string[,] arString)
        {
            string[] ans = new string[15];
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ans[count] = arString[i, j];
                    count++;
                }
            }

            return ans;
        }
        //Method that takes dynamic parameters to accept any data type value from the test
        public static List<string> convertToList(dynamic[] sArray1, dynamic[] sArray2)
        {
            List<string> ans = new List<string>();
            
            //correct answers first
            for (int x = 0; x < sArray1.Length; x++) 
            {
                ans.Add(sArray1[x]);
            }
            //user's answers next
            for (int y = 0; y < sArray2.Length; y++) 
            {
                ans.Add(sArray2[y]);
            }
           return ans;
        }
    }
}
