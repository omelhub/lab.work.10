using System;

namespace lab.work._10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            School school = new School();
            Random rnd = new Random();
            uint numstudents = 50_000_000;
            for (uint i = 0; i < numstudents; i++)
            {
                school.Students.Add(new Student
                {
                    Number = i,
                    CountPhone = (uint)rnd.Next(128,9_274_183),
                    CountLunch = (uint)rnd.Next(2,10),
                    Position = (Position)rnd.Next(0,3),
                });
            }
            (Student Bustler, Student Sloth) resultofday = school.FindMinMaxEmployee();
            Console.WriteLine($"Данные о лучшем ученике...\nИзготовил телефонов: {resultofday.Bustler.CountPhone} шт.\n" +
                              $"Обедов на счёте: {resultofday.Bustler.CountLunch} шт.\n" +
                              $"Ступень образования: {resultofday.Bustler.Position}\n" +
                              $"Серийный номер: {resultofday.Bustler.Number}_RND\n");

            Console.WriteLine($"Данные о худшем ученике...\nИзготовил телефонов: {resultofday.Sloth.CountPhone} шт.\n" +
                              $"Обедов на счёте: {resultofday.Sloth.CountLunch} шт.\n" +
                              $"Ступень образования: {resultofday.Sloth.Position}\n" +
                              $"Серийный номер: {resultofday.Sloth.Number}_RND\n");

            Console.WriteLine($"Время выполнения программы: {(DateTime.Now - start).TotalSeconds} секунд.");
            Console.ReadKey();
        }
    }
}
