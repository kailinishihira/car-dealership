using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private string _color;
    private int _year;
    private int _mileage;
    // private float _price;

    public static List<Car> _carInstances = new List<Car> ();

    public Car(string makeModel, string color, int year, int mileage)
    {
      _makeModel = makeModel;
      _color = color;
      _year = year;
      _mileage = mileage;
      // _price = price;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetColor()
    {
      return _color;
    }
    public void SetColor(string newColor)
    {
      _color = newColor;
    }
    public int GetYear()
    {
      return _year;
    }
    public void SetYear(int newYear)
    {
      _year = newYear;
    }
    public int GetMileage()
    {
      return _mileage;
    }
    public void SetMileage(int newMileage)
    {
      _mileage = newMileage;
    }
    // public float GetPrice()
    // {
    //   return _price;
    // }
    // public void SetPrice(float newPrice)
    // {
    //   _price = newPrice;
    // }
    public static void Save(Car newCar)
    {
      _carInstances.Add(newCar);
    }
    public static void RemoveCar(Car newCar)
    {
      _carInstances.Remove(newCar);
    }
  }
}
