using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_3
{
  internal class Program
    {
        static void Main(string[] args)
        {
            var barbellExercise = new BarbellExercise("Приседания со штангой", 60.0);
            var dumbbellExercise = new DumbbellExercise("Подъем гантелей на бицепс", 15.0);

            var training = new Training<ExerciseBase>();
            
            training.ExercisesList.Add(barbellExercise);
            training.ExercisesList.Add(dumbbellExercise);

            training.ExercisesPrint();
        }
    }
}