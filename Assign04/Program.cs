using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assign04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Example Input: 5  Output: 1, 2, 3, 4, 5

            //Console.WriteLine("Enter an integer number");
            //int num = int .Parse(Console.ReadLine() ?? "0");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(i+1);
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Example Input: 5  Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //Console.WriteLine("Enter an integer number");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //for (int i = 0; i < 12; i++) 
            //{ 
            //    Console.WriteLine(num*(i+1));
            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Example: Input: 15  Output: 2 4 6 8 10 12 14

            //Console.WriteLine("Enter an integer number");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //for (int i=1; i<= num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Example: Input: 4 3 Output: 64  Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //Console.WriteLine("Enter two integer number");
            //int num1 = int.Parse(Console.ReadLine() ?? "0");
            //int num2 = int.Parse(Console.ReadLine() ?? "0");
            //int thePower = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    thePower = thePower * num1;
            //}
            //Console.WriteLine($"{num1}^{num2}={thePower}");


            //Console.WriteLine("Enter two integer number");
            //int num1= int.Parse(Console.ReadLine() ?? "0");
            //int num2= int.Parse(Console.ReadLine() ?? "0");
            //double thePower = Math.Pow(num1, num2);
            //Console.WriteLine($"{num1}^{num2}={thePower}");



            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            ////Example Input: -Enter Marks of five subjects: 95 76 58 90 89 Output: Total marks = 408 Average Marks = 81  Percentage = 81

            //Console.WriteLine("Enter Marks of five subjects");
            //int[] marks = new int[5];
            //int total = 0;
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine() ?? "0");
            //    total = total + marks[i];
            //}
            //double avg = total / marks.Length;
            //double perc = (total / 5);
            //Console.WriteLine($"total = {total}");
            //Console.WriteLine($"average = {avg}");
            //Console.WriteLine($"percentage = {perc} % ");

            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter a string");
            //Console.Write($"S : ");
            //string S = Console.ReadLine() ?? "0";
            //Char[] CS = S.ToCharArray();
            //Array.Reverse(CS);
            //string RS = new string(CS);
            //Console.WriteLine($"RS : {RS}");

            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter an int num ");
            //Console.Write($"num = ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //string numString = num.ToString();
            //Char[] chars = numString.ToCharArray();
            //Array.Reverse( chars );
            //string rever = new string( chars );
            //Console.WriteLine($"Reverse num = {rever}");

            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Test Data :Input starting number of ranges: 1 Input ending number of range: 50
            //Expected Output :The prime number between 1 and 50 are: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //Console.WriteLine("Enter two int num ");
            //Console.Write($"num1= ");
            //int num1 = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write($"num2= ");
            //int num2 = int.Parse(Console.ReadLine() ?? "0");
            //for (int i = num1; i <= num2; i++)
            //{
            //    if ((i <= 1) && (i % 2 == 0 || i % 3 == 0 || i % 5 == 0)) break;
            //    else if (i == 2 || i == 3 || i == 5) Console.WriteLine(i);
            //    else Console.WriteLine(i);

            //}


            #endregion

                    #region 9-Write a program in C# Sharp to convert a decimal number into binary without using an array.
                    //Test Data :Enter a number to convert: 25 Expected Output :The Binary of 25 is 11001.


                    #endregion

                    #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.


                    #endregion

                    #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
                    //Console.Write("Enter the size n ");
                    //int n = int.Parse(Console.ReadLine() ?? "0");

                    //Console.WriteLine("Identity Matrix:");
                    //for (int i = 0; i < n; i++)
                    //{
                    //    for (int j = 0; j < n; j++)
                    //    {
                    //        if (i == j)
                    //            Console.Write("1 ");
                    //        else
                    //            Console.Write("0 ");
                    //    }
                    //    Console.WriteLine();
                    //}



                    #endregion

                    #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
                    //int[] arr = { 1, 6, 3, 9, 8 };
                    //int sum = 0;
                    //for (int i = 0; i < arr.Length; i++)
                    //{
                    //    sum = sum + arr[i];
                    //}
                    //Console.WriteLine(sum);
                    #endregion

                    #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

                    //int[] arr1 = { 1, 6, 3, 9, 8 };
                    //int[] arr2 = { 0, 8, 3, 6, 4 };
                    //int[] arr3 = new int[arr1.Length + arr2.Length];
                    //Array.Copy(arr1, arr3, arr1.Length);
                    //Array.Copy(arr2,0,arr3,arr1.Length , arr2.Length);
                    //Array.Sort(arr3);
                    //foreach (int item in arr3)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    #endregion

                    #region 14- Write a program in C# Sharp to count the frequency of each element of an array.

                    #endregion

                    #region 15- Write a program in C# Sharp to find maximum and minimum element in an array

                    //int[] array = { 10, 20, 30, 40, 50, 60 };
                    //int max = array[0];
                    //int min = array[0];
                    //for (int i = 0; i < array.Length ; i++)
                    //{
                    //    if (array[i] > max)
                    //    {
                    //        max = array[i];
                    //    }
                    //    if (array[i] < min)
                    //    {
                    //        min = array[i];
                    //    }
                    //}
                    //Console.WriteLine(max);
                    //Console.WriteLine(min);
                    #endregion

                    #region 16- Write a program in C# Sharp to find the second largest element in an array.
                    //int[] array = { 1, 20, 17, 8, 5, 9, 6, 62, 7 };
                    //Array.Sort(array); 
                    //Array.Reverse(array);  
                    //Console.WriteLine( array[1]);


                    #endregion

                    #region 17-. Consider an Array of Integer values with size N, having values as in this Example
                    // 7_ 0    0_0_0_5_6_7_5_0_7_5_3
                    //write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).
                    //In the example above, the longest distance is between the first 7 and the10th 7, with a distance of 8 cells, i.e.the number of cells between the 1stAnd the 10th 7s.
                    //Note:-Array values will be taken from the user-If you have input like 1111111 then the distance is the number of-Cells between the first and the last cell.

                    //Console.Write("Enter the Len. of the array: ");
                    //int N = int.Parse(Console.ReadLine());
                    //int[] arr = new int[N];
                    //Console.WriteLine("Enter the values of the array:");
                    //int dis = 0;
                    //for (int i = 0; i < N; i++)
                    //{
                    //    arr[i] = int.Parse(Console.ReadLine() ?? "0");
                    //}
                    //for (int i = 0; i < N; i++)
                    //{
                    //    for (int j = i + 1; j <= N; j++)
                    //    {
                    //        if (arr[i] == arr[j])
                    //            dis = j - i;
                    //        int maxdis = Math.Max(dis, arr[i]);

                    //    }
                    //}


                    #endregion

                    #region 18- Given a list of space separated words, reverse the order of the words.
                    //Input: this is a test Output: test a is this  Input: all your base  Output: base your all  Input: Word Output: Word
                    //Note : Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement

                    //Console.WriteLine("Enter the words");
                    //string words = Console.ReadLine() ?? "0";
                    //string[]thewords=words.Split(' ');
                    //Array.Reverse(thewords);
                    //string reversedThewords = string.Join(" ", thewords);
                    //Console.WriteLine(reversedThewords);


                    #endregion

                    #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

                    //int[,] arr1 = new int[2, 2];
                    //int[,] arr2 = new int[2, 2];
                    //Console.WriteLine("Enter the values for array ");
                    //for (int i = 0; i < arr1.GetLength(0); i++)
                    //{
                    //    for (int k = 0; k < arr1.GetLength(1);)
                    //    {
                    //        bool Flag = int.TryParse(Console.ReadLine(), out arr1[i, k]);
                    //        if (Flag)
                    //            ++k;
                    //    }
                    //}
                    //Array.Copy(arr1, arr2, arr1.Length);
                    //for (int i = 0; i < arr2.GetLength(0); i++)
                    //{
                    //    for (int k = 0; k < arr2.GetLength(1); k++) 
                    //    {

                    //        Console.WriteLine(arr2[i, k]);
                    //    }
                    //}
                    #endregion

                    #region 20- Write a Program to Print One Dimensional Array in Reverse Order
                    //int[] arr = { 1, 2, 3, 4, 5 };
                    //Array.Reverse(arr);
                    //foreach (int element in arr)
                    //{
                    //    Console.Write(element);
                    //}


                    #endregion

        }

    }
}
