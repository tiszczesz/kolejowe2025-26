using System;

namespace cw8_mvc_files.Models;

public interface IFishRepo
{
    public List<Fish> GetFishes();
    public void AddFish(Fish fish);
    public Fish? GetFishById(int id);
    public void UpdateFish(Fish fish);
    public void DeleteFish(int id);
}
