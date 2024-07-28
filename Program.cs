using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace CsArrayCollectionDayTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ////Single Dimensional-
            //Console.WriteLine("Enter the number of students"); 
            //int count = Convert.ToInt32(Console.ReadLine());
            //int[] stuNumber = new int[count];
            ////To get input for student numbers
            //for (int i = 0; i < stuNumber.Length; i++)
            //{
            //    Console.WriteLine($"Enter the register number for student {i + 1}");
            //    stuNumber[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            ////To Print the student numbers
            //for (int i = 0; i < stuNumber.Length; i++)
            //{
            //    Console.WriteLine($"Register Number {i + 1} : {stuNumber[i]}");
            //}

            //string[] fruits = { "Pear", "Jack Fruit", "Apple", "Orange", "Pine Apple" };
            //Console.WriteLine("Total Count :" + fruits.Length);
            //foreach (string s in fruits)
            //{
            //    Console.WriteLine(s);
            //}
            //Array.Sort(fruits);
            //Console.WriteLine("---After Sorted");
            //foreach (string s in fruits)
            //{
            //    Console.WriteLine(s);
            //}
            //Array.Reverse(fruits);
            //Console.WriteLine("\n--After Reversed---\n");
            //foreach (string s in fruits)
            //{
            //    Console.WriteLine(s);
            //}

            // jagged array  array ke andar array
            //int[] a = { 1, 2, 3 ,5};
            //int[][] jaggedarray = new int[3][];
            //jaggedarray[0] = new int[3];
            //jaggedarray[1] = a;
            //jaggedarray[2] = new int[4];

            //var res = fruits.Count();
            //Console.WriteLine("-----" + res);

            //-Jagged Array
            //double[][] certificationMarks = new double[3][];
            //Console.WriteLine(certificationMarks.Length);
            //Console.WriteLine(certificationMarks.GetLength(0));
            //for (int i = 0; i < certificationMarks.Length; i++)
            //{
            //    Console.WriteLine($"Enter the number of certifications obtained by " + $"Employee {i + 1}");
            //    int colLength = Convert.ToInt32(Console.ReadLine());
            //    certificationMarks[i] = new double[colLength]; for (int j = 0; j < colLength; j++)
            //    {
            //        Console.WriteLine($"Enter the marks for certification{j + 1} ");
            //        certificationMarks[i][j] = Convert.ToDouble(Console.ReadLine());

            //    }
            //}

            //char[] ar = { 'a', 'l' };
            //string name = "Alice";
            //string name2 = "Bob";
            //string s3 = new string("leo");
            //string s5 = new string(name);
            //string s4=new string(ar);

            //Console.WriteLine(s4);

            //string userName = null;
            //string password;

            //if username is null na should print
            //Console.WriteLine(userName ?? "NA");
            //Console.WriteLine(userName ??= "NA");

            //Console.WriteLine(userName.Length);

            //Console.WriteLine("Enter user name");
            //userName=Console.ReadLine();
            //Console.WriteLine("Enter password");

            //password=Console.ReadLine();    

            //if(userName.Length==0 && password.Length == 0)
            //{
            //    Console.WriteLine("Enter valid user name and password");
            //}
            //else
            //{
            //    if (userName.Equals("Victor") && password.Equals("secret@123"))
            //    {
            //        Console.WriteLine("You are successfully logged in");
            //    }
            //    else
            //    {
            //        Console.WriteLine("wrong passord or ussername");
            //    }
            //}


            //string empcode = "K2p-101-202";
            //Console.WriteLine(empcode.Substring(4,3));
            //Console.WriteLine(empcode.Contains("k2p",StringComparison.OrdinalIgnoreCase));

            //Write a program that counts the number of occurrences of a particular character in a line of text.
            //Console.WriteLine("Enter the text ");
            //string msg = Console.ReadLine();
            //Console.WriteLine("enter the char of which you want to count the ooccurrences");
            //char ch = Convert.ToChar(Console.ReadLine());
            //int count = 0;
            //msg.ToCharArray();
            //for(int i = 0; i < msg.Length; i++)
            //{
            //    if (msg[i]==ch)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"answer is : {count}");

            //Write a program that reads a string and rewrite it in alphabetical order. For example the word STRING
            //    should be written as GINRST
            //Console.WriteLine("Enter a string");
            //string msg=Console.ReadLine();
            //Console.WriteLine("alphabetical order of your string is ");
            //char[] temp =msg.ToCharArray();
            //Array.Sort(temp);
            //foreach(char c in temp){
            //    Console.Write(c);
            //}

            //Write a program in C# Sharp to extract a substring from a given string
            //Console.WriteLine("Enter the mssg ");
            //string msg=Console.ReadLine();
            //Console.WriteLine("Enter the first index which you want to include");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the last index. it will not be included");
            //int end = Convert.ToInt32(Console.ReadLine());

            //if (start > 0 && start < msg.Length && end >= start && end < msg.Length)
            //{
            //    string ans = msg.Substring(start, end);
            //    Console.WriteLine($"the substring : {ans}");
            //}
            //else
            //{
            //    Console.WriteLine("not valid start or end index");
            //}

            //Write a program in C# Sharp to search the position of a substring within a string
            //Console.WriteLine("Enter the mssg ");
            //string msg=Console.ReadLine();
            //Console.WriteLine("Enter the substring which you want to search");
            //string sub=Console.ReadLine();
            //if (msg.Contains(sub))
            //{
            //    Console.WriteLine("index of sub string start is : "+msg.IndexOf(sub));
            //    int temp = msg.IndexOf(sub) + sub.Length - 1;
            //    Console.WriteLine("index of sub string end is : "+ temp);
            //}
            //else
            //{
            //    Console.WriteLine("the given sub string is not present");
            //}


            //Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores
            //Console.WriteLine("Enter string 1");
            //string s1=Console.ReadLine();
            //Console.WriteLine("Enter string 2");
            //string s2 = Console.ReadLine();

            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s1.Equals(s2,StringComparison.OrdinalIgnoreCase));

            //Write a program in C# Sharp to delete an element at desired position from an array
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            a.SetValue(1, 4);
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }

            //            PAN Card Validation
            //Develop an application to validate the PAN number of a person using regular expression.
            //Create a class UserMain and do the I/O operations.Refer the samples given, to read and display the data.
            //Sample Input 1:
            //Enter your name :
            //Sarah
            //Enter your PAN number :
            //SSTHP1234L
            //Sample Output 1:
            //Valid PAN number.
            //Sample Input 2:
            //Enter your name :
            //Polemon
            //Enter your PAN number :
            //GBSPL78945
            //Sample Output 2:
            //Invalid PAN number.

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your PAN Number");
            string pan = Console.ReadLine();
            //Match match = new Match(pan);
            string reg = @"(^[A-Z]{5}[0-9]{4}[A-Z]{1})";
            Regex r = new Regex(reg);
            
            if (r.IsMatch(pan))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");

            }












        }
    }
}
