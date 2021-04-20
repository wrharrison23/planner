using System;
using System.Collections.Generic;

namespace Planner
{

  public class City
  {
    public City(string name)
    {
      _name = name;
    }
    private string _mayor { get; set; } = "Wes";
    private int _yearEstablished { get; set; }
    private string _name { get; set; }
    public List<Building> Buildings = new List<Building>();


  public void AddBuilding(Building building) 
      {
      Buildings.Add(building);
      }

      public void Establish() 
      {
        _yearEstablished = DateTime.Now.Year;
      }

  }
}