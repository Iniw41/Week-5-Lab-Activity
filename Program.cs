using System;

namespace Assignment_Week5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteCentered("Shape Calculator\n");
            WriteCentered("\n1. Calculate: AreaCircle");
            WriteCentered("\n2. Calculate: VolumeCube");
            WriteCentered("\n3. Calculate: PerimeterTriangle");
            WriteCentered("\n4. Calculate: SurfaceAreaRectangle");
            WriteCentered("\n5. Exit");

            while (true)
            {
              var keypress = Console.ReadKey(true);
              switch (keypress.Key)
              {
                  case ConsoleKey.D1:
                      

                      break;
                  case ConsoleKey.D2:
                      
                      
                      break;
                  case ConsoleKey.D3:
                      
                      
                      break;
                  case ConsoleKey.D4:
                      
                      break;
                  case ConsoleKey.D5:
                  
                      WriteAtBottom("Exiting...");
                      return; 
                  default:
                      Console.WriteLine("Invalid selection. Please choose 1-5.");
                      break;
              }
              
            }
        }

        static void WriteCentered(string text)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int leftPadding = Math.Max((windowWidth - textLength) / 2, 0);
            Console.SetCursorPosition(leftPadding, Console.CursorTop);
            Console.WriteLine(text);
            Console.WriteLine();
        }
        static void WriteAtBottom(string text)
        {
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            int textLength = text.Length;
            int leftPadding = Math.Max((windowWidth - textLength) / 2, 0);

            // Set cursor to the last line
            Console.SetCursorPosition(leftPadding, windowHeight - 1);
            Console.WriteLine(text);
        }
      
        static void AC_input();
        {
            Console.Clear();
            while (true)
            {
              
            }
        }
    }

    public class Shape
    {
        // Static method: pass by value
        public static double AreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Static method: pass by reference
        public static void VolumeCube(double side, ref double volume)
        {
            volume = Math.Pow(side, 3);
        }

        // Instance method: pass by value
        public double PerimeterTriangle(double a, double b, double c)
        {
            return a + b + c;
        }

        // Instance method: pass by reference
        public void SurfaceAreaRec(double width, double height, ref double area)
        {
            area = width * height;
        }
    }
}
