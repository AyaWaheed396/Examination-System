using System.Diagnostics;

namespace Exam
{

    internal class Program
    {
        public enum ExamType
        {
            Practical = 1,
            Final = 2
        }

        public enum QuestionType
        {
            MCQ = 1,
            TrueFalse = 2
        }

        static void Main(string[] args)
        {
            Subject sub1 = new Subject(1,"C#");
            sub1.CreateExam();
                      

        }
    }
}