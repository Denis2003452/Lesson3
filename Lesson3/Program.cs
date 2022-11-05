namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student();
            student1.Health = 100;
            student1.Intellect = 20;
            student1.Knowladge = 10;
            student1.Happiness = 100;

            student1.HaveFun();           
            student1.TakeTheExam();
            student1.Study();         
        }
    }
    public class Student
    {
        public int Health;
        public int Intellect;
        public int Happiness;
        public int Knowladge;

        public void HaveFun()
        {
            Happiness += 10;
            Knowladge -= 5;
            Console.WriteLine($"Студент повеселился.Счтастье:{Happiness}.Знания:{Knowladge}");
        }
        public void Study()
        {
            Happiness -= 10;
            Intellect += 1;
            Knowladge += 2;
            Console.WriteLine($"Студент поучился.Счтастье:{Happiness}.Знания:{Knowladge},Интелект:{Intellect}");
        }
        public void TakeTheExam()
        {
            Health -= 20;
            Happiness += 100;
            Console.WriteLine($"Студент сдал экзамен.Счтастье:{Happiness}.Здоровье:{Health}");
        }

    }
}