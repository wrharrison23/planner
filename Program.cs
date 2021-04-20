using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building FiveOneTwoEigth = new Building("512 8th Avenue")
      {
        Width = 250.50,
        Stories = 2,
        Depth = 56
      };
      FiveOneTwoEigth.Construct();
      FiveOneTwoEigth.Purchase("Bill Gates");

      Building OneHundredMain = new Building("100 Main St.")
      {
        Width = 450,
        Stories = 6,
        Depth = 200
      };
      OneHundredMain.Construct();
      OneHundredMain.Purchase("Elon Musk");

      Building SixtySixHigh = new Building("66 High St.")
      {
        Width = 300,
        Stories = 15,
        Depth = 200
      };
      SixtySixHigh.Construct();
      SixtySixHigh.Purchase("Jeff Bezos");

      City Shepherdstown = new City("Shepherdstown");
      Shepherdstown.Establish();
      Shepherdstown.AddBuilding(FiveOneTwoEigth);
      Shepherdstown.AddBuilding(OneHundredMain);
      Shepherdstown.AddBuilding(SixtySixHigh);

      foreach(Building building in Shepherdstown.Buildings)
      {
        building.WriteBuilding();
      }
    }
  }
}