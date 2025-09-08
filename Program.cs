
namespace Assignemnt_Week5
{
  internal class Program
  {
      private static void Main (string[] args)
      {
        WriteCentered("Shape Calculator");
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
  }

  public class Shapes
  {
    public void AreaCircle()
    {
      
    }
    public void VolumeCube() 
    {
      
    }
    public void PerimiterTriangle()
    {
      
    }
    public void SufaceAreaRec()
    {
      
    }
  }
}
