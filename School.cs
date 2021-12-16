using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._10
{
    class School
    {
        public List<Student> Students { set; get; } = new List<Student>();
        
        public (Student Bustler, Student Sloth) FindMinMaxEmployee() //Bustler = торопыга, Sloth = ленивец
        {
            Students.Sort();
            (Student, Student) result = (Students.Last(), Students.First()); //var
            Reward(ref result);
            return (Students.Last(), Students.First());

            // метод, ищущий самого производительного и самого медлительного школьника по итогом урока,
            // запускает метод Reward() и возвращает кортеж.
        }

        void Reward(ref (Student, Student) result)
        {
            result.Item1.CountLunch += 1;
            result.Item2.CountLunch -= 1;

            //метод принимает кортеж данных из FindMinMaxEmployee() по ссылке,
            //прибавляет обед торопыге и вычитает обед у ленивца.
        }
    }
}
