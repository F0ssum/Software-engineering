using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_3
{
  public abstract class ExerciseBase
    {
        private string exerciseName;
        public string ExerciseName
        {
            get { return exerciseName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Упражнение не может быть пустым.", nameof(ExerciseName));
                }
                exerciseName = value;
            }
        }

        public double Weight { get; set; }

        protected ExerciseBase(string exerciseName, double weight)
        {
            ExerciseName = exerciseName;
            Weight = weight;
        }
    }
}
