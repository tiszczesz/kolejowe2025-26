using System;

namespace cw3_layout.Models;

public class FakeCarsRepo : ICarsRepo

{
    private List<Car> _Cars = new List<Car>
    {
        new Car{ Brand="Toyota", Model="Corolla", Year=2020},
        new Car{ Brand="Honda", Model="Civic", Year=2019},
        new Car{ Brand="Ford", Model="Focus", Year=2018},
        new Car{ Brand="Chevrolet", Model="Malibu", Year=2021},
        new Car{ Brand="Nissan", Model="Sentra", Year=2017}
    };
    public FakeCarsRepo()
    {
        Cars = _Cars;
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
        return Cars.FirstOrDefault(c => c.Id == id);
    }

    public void RemoveCar(int id)
    {
        throw new NotImplementedException();
    }
}
