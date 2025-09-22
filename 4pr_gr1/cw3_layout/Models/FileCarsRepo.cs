using System;

namespace cw3_layout.Models;

public class FileCarsRepo : ICarsRepo
{
    public List<Car> Cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AddCar(Car car)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAllCars()
    {
        throw new NotImplementedException();
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
