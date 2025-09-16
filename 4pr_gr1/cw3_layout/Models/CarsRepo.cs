using System;

namespace cw3_layout.Models;

public class CarsRepo
{
    public List<Car> Cars = new List<Car>
    {
        new Car{ Brand="Toyota", Model="Corolla", Year=2020},
        new Car{ Brand="Honda", Model="Civic", Year=2019},
        new Car{ Brand="Ford", Model="Focus", Year=2018},
        new Car{ Brand="Chevrolet", Model="Malibu", Year=2021},
        new Car{ Brand="Nissan", Model="Sentra", Year=2017}
    };

}
