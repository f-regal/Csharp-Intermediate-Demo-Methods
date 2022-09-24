﻿namespace Csharp_Intermediate_Demo_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var point = new Point(10,20);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
                //CONTINUE FROM MIN 18.02
            }
        }
    }
}