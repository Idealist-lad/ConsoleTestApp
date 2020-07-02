using System;
using System.Collections;

namespace ProgAssign2.test
{
    class Student
    {
        dynamic studentNumber;
        dynamic name;
        string[] userAnswer;
        // constructor
        public Student() 
        {
            
            userAnswer = new string[3];
        }
        //polymorphism - dynamic parameters
        public Student(dynamic stdNumber, dynamic nm) 
        {
            studentNumber = stdNumber;
            name = nm;
        }
  
        //returns userData
        public string[] takeTest(ArrayList arTest) 
        {
            Console.Write("Enter your Student Id number :");
            studentNumber = Console.ReadLine();
            Console.Write("Enter your name :");
            name = Console.ReadLine();
            //Variables
            //To count the marks that will be obtained by the student when taking the test
            int count = 0;
            string[] ans = new string[3];
            string divider = "\n_________________________________________\n";

            //PROCESS
            //Forloop to run the test for student set by the lecturer
            for (int x = 0; x < arTest.Count; x = x + 5)
            {
                Console.WriteLine(divider + "Question {0} |\n" + arTest[x], (count + 1));
                Console.Write("a) {0}", arTest[x + 1] + "\n");
                Console.Write("b) {0}", arTest[x + 2] + "\n");
                Console.Write("c) {0}", arTest[x + 3] + "\nEnter your answer: ");
                ans[count] = Console.ReadLine();
                count++;
            }

            //OUTPUT
            userAnswer = ans;
            return ans;
        }
        //Stored answers for the student
        public string[] getUserAnswer()
        {
            return userAnswer;
        }
    }
}
