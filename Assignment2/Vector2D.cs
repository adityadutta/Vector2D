using System;

namespace Assignment2
{
    class Vector2D
    {

        //Declaring two variables to store vector 1
        private double x;
        private double y;

        //getter and setter for x
        public double X
        {
            get{ return x; }
            set { x = value; }
        }
        //getter and setter for y
        public double Y
        {
            get { return y; }
            set { x = value; }
        }
        //constructor to initialize object of class
        public Vector2D(double xValue, double yValue)
        {
            x = xValue;
            y = yValue;
        }

        //flipping sign for x
        public void NegateX()
        {
            Console.WriteLine("NegateX : " + (x *= -1));
        }

        //flipping sign for y
        public void NegateY()
        {
           Console.WriteLine("NegateY : " + (y *= -1));
        }

        //vector addition
        public void AddVector(double xValue, double yValue)
        {
            Console.WriteLine("Vector Addition: [" + (xValue + x) + "," + (yValue + y) + "]");
        }

        //vector subtraction
        public void SubtractVector(double xValue, double yValue)
        {
            Console.WriteLine("Vector Subtraction: [" + (xValue - x) + "," + (yValue - y) + "]");
        }

        //scalar multiplication 
        // scalar * [x , y]
        public void ScalarMultiplication(double scalar)
        {
            Console.WriteLine("Scalar Multiplication: [" + (x *= scalar) + "," + (y *= scalar) + "]");          
        }

        //Getting magnitude using pythagorean theorem
        // r^2 = a^2 + b^2
        public double GetMagnitude()
        {
           
            return (Math.Sqrt(x*x + y*y));
        }

        //Getting angle in radians and converting it into degrees using 180/PI
        public double GetAngleInDegrees()
        {
            if (x > 0 && y > 0)
                Console.Write("The coordinate point ({0} , {1}) lies in the First quandrant.\n\n", x, y);
            else if (x < 0 && y > 0)
                Console.Write("The coordinate point ({0} , {1}) lies in the Second quandrant.\n\n", x, y);
            else if (x < 0 && y < 0)
                Console.Write("The coordinate point ({0} , {1}) lies in the Third quandrant.\n\n", x, y);
            else if (x > 0 && y < 0)
                Console.Write("The coordinate point ({0} , {1}) lies in the Fourth quandrant.\n\n", x, y);
            else if (x == 0 && y == 0)
                Console.Write("The coordinate point ({0} , {1}) lies at the origin.\n\n", x, y);
            return ((Math.Atan(y / x)) * (180/Math.PI));
        }

    }
}
