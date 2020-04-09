using System;

namespace itProger
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] digits = new byte[5];

            digits[0] = 34;
            digits[4] = 255;

            Console.WriteLine(digits[3]);

            string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };

            Console.WriteLine(students[1]);

            short[,] nums = new short[5, 2];

            int[,] numbers = {
                  { 5, 7, 2 },
                  { 9, 200, 8 },
                  { 7, 0, 12 }
             };
            int len = students.Length;
            Console.WriteLine(len);

            //Array.Clear(students, 0, len);

            Console.WriteLine(students[1]);

            string[] copyStudents = new string[len];
            students.CopyTo(copyStudents, 0);

            Console.WriteLine(students[1]);


            int[,,] numbers_2 = {
            {
             { 2, 5, 6 },
             { 2, 5, 6 },
             { 2, 5, 6 },
            },
             {
                    { 2, 5, 6 },
                    { 2, 5, 6 },
                    { 2, 5, 6 }
             },
             };

            numbers[2, 0] = 50;

            Console.WriteLine(numbers[1, 1]);
            
            Console.ReadKey();
         }
    }
}
