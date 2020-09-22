using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void TriangleType_IsItATriangle_True()
    {
      Assert.AreEqual("not a triangle", Triangle.TriangleType(2, 0, 3));
    }

    [TestMethod]
    public void TriangleType_IsItEqualateral_True()
    {
      Assert.AreEqual("equilateral triangle", Triangle.TriangleType(4, 4, 4));
    }

    [TestMethod]

    public void TriangleType_IsItIsoceles_True()
    {
      Assert.AreEqual("isosceles triangle", Triangle.TriangleType(4, 4, 2));
    }

    [TestMethod]

    public void Triangle_IsItScalene_True()
    {
      Assert.AreEqual("scalene triangle", Triangle.TriangleType(3, 4, 5));
    }
  }
}

