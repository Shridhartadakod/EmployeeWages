using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsion
{
    internal class LineComparsionProcess
    {
        public int X_one;
        public int X_two;
        public int Y_one;
        public int Y_two;
        public int A_one;
        public int B_one;
        public int A_two;
        public int B_two;
        public double Length_XY;
        public  double Length_AB;
        public void length_line()
        {
            Console.WriteLine("enter x,y co-ordinates of the line 1 :");
            Console.WriteLine("enter value of X_one");
            X_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of X_two");
            X_two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of Y_one");
            Y_one=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of Y_two");
            Y_two=Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("enter the x,y co-ordinates of line 2 :");
            Console.WriteLine("enter value of A_one");
            A_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of A_two");
            A_two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of B_one");
            B_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of B_two");
            B_two = Convert.ToInt32(Console.ReadLine());


            Length_XY = Math.Sqrt(Math.Pow((X_two - X_one), 2) + Math.Pow((Y_two - Y_one), 2));
            Console.WriteLine("Length of value 1 is :" + Length_XY);

            Length_AB = Math.Sqrt(Math.Pow(A_two - A_one, 2) + Math.Pow((B_two - B_one), 2));
            Console.WriteLine("Length of vaule 2 is :" + Length_AB);
            Console.ReadLine();
        }


        public void Compareline()
        {
            double Diff = Length_XY.CompareTo(Length_AB);
            if(Diff == 0)
            {
                Console.WriteLine("length of XY is equal to AB");
            }
            if(Diff < 0)
            {
                Console.WriteLine("length of XY is less than AB");
            }
            if(Diff > 0)
            {
                Console.WriteLine("length of XY is greater than AB");
            }
            Console.ReadLine();
        }

    }
}
