namespace TriangleTracker
{
  public class Triangle
  {
    static public string TriangleType(int side1, int side2, int side3)
    {
      if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
      {
        return "not a triangle";
      }
      else if (side1 == side2 && side1 == side3)
      {
        return "equilateral triangle";
      }
      else if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        return "isosceles triangle";
      }
      else if (side1 != side2 && side1 != side3 && side2 != side3)
      {
        return "scalene triangle";
      }
      else
      {
        return "error";
      }


    }

  }
}