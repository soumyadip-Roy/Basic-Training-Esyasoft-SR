namespace MyFirstConsoleApp
{
    internal class Program
    {
        static int sum;
        static void Main(string[] args)
        {
            //int num1, num2;
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Enter first number");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //sum = num1 + num2;
            //Console.WriteLine("The sum is: " + sum);
            //var myResult = Addition(num1, num2);
            //string name = "abcd";
            //string displayName = name ?? "Unknown";
            //Console.WriteLine(displayName); // Output: Unknown
            //Console.WriteLine(myResult.firstnumber); // Output: Unknown
            ////Console.WriteLine("Hello, World!");

            Console.WriteLine("Hello Welcome to the School Website");
            Console.Write("Please Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            var data = ReportAverage(5);
            //int i = 0;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Subject Report Card (For Validation)");
            Console.WriteLine("");
            for (int i =0; i<5;i++)
            {
                Console.WriteLine("Subject" + i + ":" + data.arr[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(gradeGenerator(data.avg));



        }

        static (float avg, int[] arr) ReportAverage(int numOfSubjects)
        {
            Console.WriteLine("Student Report Generator");
            Console.WriteLine("Please Enter The Marks in Each Subject Out of 100");
            int sum = 0;
            int[] arr = new int[numOfSubjects];
            for (int i=0; i < numOfSubjects; i++)
            {
                Console.Write("Subject" + i + " :");
                arr[i] = Convert.ToInt16(Console.ReadLine());
                sum += arr[i];
            }
            float average = sum / numOfSubjects;
            return (average, arr);
        }

        static char gradeGenerator(float avg)
        {
            Console.WriteLine("The Average Score of the Student is: " + avg);
            int gradeValue = 10-(Convert.ToInt16(avg) / 10)-1;
            char gradLetter = Convert.ToChar(Convert.ToInt16('A') + gradeValue);
            if (gradeValue < 4) {
                gradLetter = 'F';
                    }
            return (gradLetter);
            
        }

        static (int firstnumber, int secondnumber, int result) Addition(int firstnumber, int secondnumber)
        {
            Console.WriteLine("Reached Addition method");
            sum = firstnumber + secondnumber;
            Console.WriteLine("The sum of {0} and {1} is :{2}", firstnumber, secondnumber, sum);
            return (firstnumber, secondnumber, sum);
        }
    }
}
