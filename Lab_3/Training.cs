using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Lab_3
{
  public class Training<T> where T : ExerciseBase
    {
        public List<T> ExercisesList = new List<T>();

        public void ExercisesPrint()
        {
            var PrintText = new StringBuilder();
            PrintText.Append("Выполнены следующие упражнения: ");
            
            foreach (var el in this.ExercisesList)
            {
                if (el != null)
                {
                    PrintText.Append($"{el.ExerciseName} (вес: {el.Weight}), ");
                }
                else
                {
                    throw new InvalidOperationException("Упражнение не может быть пустым.");
                }
            }

            if (PrintText.Length >= 2)
            {
                PrintText.Length -= 2;  // Удаление запятой
            }

            Console.WriteLine(PrintText);
        }
    }
}