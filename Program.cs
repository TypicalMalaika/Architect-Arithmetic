using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double rectArea = (Rect(2500,1500));
      double circleArea = (Circle(375)/2);
      double triangleArea = (Triangle(750,500));
      double totalArea = rectArea + circleArea + triangleArea;
      double totalCost = Math.Round((totalArea * 180),2);

      Console.WriteLine($"The rectangle area is {rectArea} meters squared. The circle area is {circleArea} meters squared.  The trianlge area is {triangleArea} meters squared.  The total area is {totalArea} meters squared. Multiplied by 180 pesos means the total cost is {totalCost} Mexican pesos.");
    }
    static double Rect(double length, double width)
    {
      return length * width;
    }
    static double Circle(double radius)
    {
      return Math.Round(Math.PI * Math.Pow(radius, 2));
    }
    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
