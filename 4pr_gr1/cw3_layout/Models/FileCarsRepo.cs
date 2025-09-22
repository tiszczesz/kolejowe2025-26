using System;
using System.Text.Json;

namespace cw3_layout.Models;

public class FileCarsRepo : ICarsRepo
{
    private readonly string filePath = "cars.json";
    private List<Car> _cars;
    private void LoadCarsFromFile()
    {
        if(!File.Exists(filePath))
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
        throw new NotImplementedException();
    }

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public Car? GetCar(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveCar(int id)
    {
        throw new NotImplementedException();
    }
}
