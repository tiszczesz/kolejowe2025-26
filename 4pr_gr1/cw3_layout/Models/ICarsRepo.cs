
namespace cw3_layout.Models ;

interface ICarsRepo
{
    public List<Car> Cars { get; set; }
    Car? GetCar(int id);
    void AddCar(Car car);
    void RemoveCar(int id);
    List<Car> GetAllCars();
    void UpdateCar(Car car);
}