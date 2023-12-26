using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2
{
public abstract class Terrain
{
    public int Altitude { get; set; }
    public double SpeedReduction { get; set; }
}

public class Meadow : Terrain
{
    public string GrassColor { get; set; }
}

public class Water : Terrain
{
    public int Depth { get; set; }
}

public class Map
{
    private List<Terrain> terrains;

        public Map()
    {
         try
        {
            terrains = new List<Terrain>
            {
                new Water { Altitude = 0, SpeedReduction = 0.8, Depth = 6 },
                new Meadow { Altitude = 10, SpeedReduction = 0.2, GrassColor = "Green" },
                new Water { Altitude = -5, SpeedReduction = 0.9, Depth = 4 },
                new Meadow { Altitude = 15, SpeedReduction = 0.1, GrassColor = "Yellow" },
                new Water { Altitude = -2, SpeedReduction = 0.85, Depth = 7 },
                new Meadow { Altitude = 20, SpeedReduction = 0.1, GrassColor = null } // Это вызовет исключение
             };

            foreach (var terrain in terrains)
            {
                if (terrain is Meadow meadow && meadow.GrassColor == null)
                {
                    throw new Exception("Поле GrassColor не может быть пустым");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при создании карты: {ex.Message}");
            Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
        }
        finally
        {
            Console.WriteLine("Карта создана.");
        }
    }

    public int CountDeepWaters()
    {
        return terrains.OfType<Water>().Count(w => w.Depth > 5);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var map = new Map();
        Console.WriteLine($"Количество полей типа «Вода», глубина которых больше 5: {map.CountDeepWaters()}");
    }
}
}
