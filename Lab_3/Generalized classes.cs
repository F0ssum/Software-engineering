using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Exercise
{
    public string Name { get; set; }
    public double Weight { get; set; }
}

public class BarbellExercise : Exercise
{
}

public class DumbbellExercise : Exercise
{
}

public class Training<T> where T : Exercise
{
    public List<T> Exercises { get; set; }

    public Training(List<T> exercises)
    {
        Exercises = exercises;
    }

    public void PerformExercises()
    {
        Console.WriteLine("Выполнены следующие упражнения:");
        foreach (var exercise in Exercises)
        {
            Console.WriteLine($"{exercise.Name} с весом {exercise.Weight}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var barbellExercises = new List<BarbellExercise>
        {
            new BarbellExercise { Name = "Приседания со штангой", Weight = 60 },
            new BarbellExercise { Name = "Жим штанги лежа", Weight = 50 },
            new BarbellExercise { Name = "Тяга штанги в наклоне", Weight = 70 }
        };

        var dumbbellExercises = new List<DumbbellExercise>
        {
            new DumbbellExercise { Name = "Подъем гантелей на бицепс", Weight = 15 },
            new DumbbellExercise { Name = "Разводка гантелей стоя", Weight = 10 },
            new DumbbellExercise { Name = "Сгибание рук с гантелями", Weight = 20 }
        };

        var barbellTraining = new Training<BarbellExercise>(barbellExercises);
        barbellTraining.PerformExercises();

        var dumbbellTraining = new Training<DumbbellExercise>(dumbbellExercises);
        dumbbellTraining.PerformExercises();
    }
}
