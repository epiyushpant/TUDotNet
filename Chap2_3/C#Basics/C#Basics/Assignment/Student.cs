namespace C_Basics.Assignment
{
    internal class Student
    {
        public static void GetGrade()
        {

            Console.Write("Enter your marks (0 - 100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100.");
                return;
            }

            int category = marks / 10;   // Divide marks into ranges (0–9)

            switch (category)
            {
                case 10:
                case 9:
                    Console.WriteLine("Grade: A+");
                    Console.WriteLine("Grade Point: 4.0");
                    Console.WriteLine("Comment: Outstanding");
                    break;

                case 8:
                    Console.WriteLine("Grade: A");
                    Console.WriteLine("Grade Point: 3.6");
                    Console.WriteLine("Comment: Excellent");
                    break;

                case 7:
                    Console.WriteLine("Grade: B+");
                    Console.WriteLine("Grade Point: 3.2");
                    Console.WriteLine("Comment: Very Good");
                    break;

                case 6:
                    Console.WriteLine("Grade: B");
                    Console.WriteLine("Grade Point: 2.8");
                    Console.WriteLine("Comment: Good");
                    break;

                case 5:
                    Console.WriteLine("Grade: C+");
                    Console.WriteLine("Grade Point: 2.4");
                    Console.WriteLine("Comment: Satisfactory");
                    break;

                case 4:
                    Console.WriteLine("Grade: C");
                    Console.WriteLine("Grade Point: 2.0");
                    Console.WriteLine("Comment: Acceptable");
                    break;

                case 3:
                    Console.WriteLine("Grade: D+");
                    Console.WriteLine("Grade Point: 1.6");
                    Console.WriteLine("Comment: Partially Acceptable");
                    break;

                case 2:
                    Console.WriteLine("Grade: D");
                    Console.WriteLine("Grade Point: 1.2");
                    Console.WriteLine("Comment: Insufficient");
                    break;

                default:
                    Console.WriteLine("Grade: E");
                    Console.WriteLine("Grade Point: 0.8");
                    Console.WriteLine("Comment: Very Insufficient");
                    break;
            }

            Console.ReadLine();

        }

        public static void GetGradeIfElse()
        {
            Console.Write("Enter your marks (0 - 100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100.");
            }
            else if (marks > 90)
            {
                Console.WriteLine("Grade: A+");
                Console.WriteLine("Grade Point: 4.0");
                Console.WriteLine("Comment: Outstanding");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("Grade Point: 3.6");
                Console.WriteLine("Comment: Excellent");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: B+");
                Console.WriteLine("Grade Point: 3.2");
                Console.WriteLine("Comment: Very Good");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("Grade Point: 2.8");
                Console.WriteLine("Comment: Good");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: C+");
                Console.WriteLine("Grade Point: 2.4");
                Console.WriteLine("Comment: Satisfactory");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("Grade Point: 2.0");
                Console.WriteLine("Comment: Acceptable");
            }
            else if (marks >= 30)
            {
                Console.WriteLine("Grade: D+");
                Console.WriteLine("Grade Point: 1.6");
                Console.WriteLine("Comment: Partially Acceptable");
            }
            else if (marks >= 20)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("Grade Point: 1.2");
                Console.WriteLine("Comment: Insufficient");
            }
            else
            {
                Console.WriteLine("Grade: E");
                Console.WriteLine("Grade Point: 0.8");
                Console.WriteLine("Comment: Very Insufficient");
            }

            Console.ReadLine();
        }
    }
}
