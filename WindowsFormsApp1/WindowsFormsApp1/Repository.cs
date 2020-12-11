using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Repository
    {
        public void AddQuestion(string text)
        {
            using (var context = new QuizContext())
            {
                var question = new QuizQuestion();
                question.Question = text;
                question.Answers = null;

                context.Questions.Add(question);
                context.SaveChanges();
            }
        }
    }
}
