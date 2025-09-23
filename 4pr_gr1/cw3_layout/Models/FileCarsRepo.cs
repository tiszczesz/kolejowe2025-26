using System;
using System.Text.Json;

namespace cw3_layout.Models;

public class FileCarsRepo : ICarsRepo
{
    private readonly string filePath = "cars.json";
    private List<Car> _cars;
    private void LoadCarsFromFile()
    {
        if (!File.Exists(filePath))
        {
            _cars = new List<Car>();
            return;
        }
        var result = File.ReadAllText(filePath);
        _cars = JsonSerializer.Deserialize<List<Car>>(result)
            ?? new List<Car>();
    }
    public FileCarsRepo()
    {
        LoadCarsFromFile();
        Cars = _cars;
    }
    public List<Car> Cars { get; set; }

    public void AddCar(Car car)
    {
        car.Id = GetNextId();
        Cars.Add(car);
        SaveToFile();
    }

    private void SaveToFile()
    {
        var json = JsonSerializer.Serialize(Cars);
        File.WriteAllText(filePath, json);
    }

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public Car? GetCar(int id)
    {
        return Cars.FirstOrDefault(c => c.Id == id);
    }

    public void RemoveCar(int id)
    {
        Car? carToRemove = Cars.FirstOrDefault(c => c.Id == id);
        if (carToRemove != null)
        {
            Cars.Remove(carToRemove);
            SaveToFile();
        }
        
    }
    private int GetNextId()
    {
        if (Cars.Count == 0) return 1;
        return Cars.Max(c => c.Id) + 1;
    }
}
