using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int op;
                char ch;
                double x1, y1, x2, y2, scalar;
                Console.Write("Enter x component of vector 1: ");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter y component of vector 1: ");
                y1 = Convert.ToDouble(Console.ReadLine());
                Vector2D vector = new Vector2D(x1, y1);

                do
                {
                    Console.WriteLine("Vector2D x component : " + vector.X + "\nVector2D y component : " + vector.Y);
                    Console.WriteLine("Vector2D\n1.NegateX\n2.NegateY\n3.Add Vectors\n4.Subtract Vectors\n5.Scalar Multiplication\n6.Get Magnitude\n7.Get Angle in Degrees\n8.Quit");
                    Console.WriteLine("\nEnter your choice: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            vector.NegateX();
                            break;
                        case 2:
                            vector.NegateY();
                            break;
                        case 3:
                            Console.Write("Enter x component of vector 2: ");
                            x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter y component of vector 2: ");
                            y2 = Convert.ToDouble(Console.ReadLine());
                            vector.AddVector(x2, y2);
                            break;
                        case 4:
                            Console.Write("Enter x component of vector 2: ");
                            x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter y component of vector 2: ");
                            y2 = Convert.ToDouble(Console.ReadLine());
                            vector.SubtractVector(x2, y2);
                            break;
                        case 5:
                            Console.Write("Enter scalar value for multiplication: ");
                            scalar = Convert.ToDouble(Console.ReadLine());
                            vector.ScalarMultiplication(scalar);
                            break;
                        case 6:
                            Console.WriteLine("Magnitude: " + vector.GetMagnitude());
                            break;
                        case 7:
                            Console.WriteLine("Angle: " + vector.GetAngleInDegrees());
                            break;
                        case 8:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Try again.");
                            break;
                    }
                    Console.WriteLine("Continue?(y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch == 'y' || ch == 'Y');
            }
            catch(Exception e)
            {
                Console.WriteLine("Error encountered: " + e.Message + "\nRun the program again! Press any key.");
                Console.ReadKey();
            }
        }
    }
}
