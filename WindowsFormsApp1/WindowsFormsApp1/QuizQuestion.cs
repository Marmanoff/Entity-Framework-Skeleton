using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class QuizQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public List<QuizAnswer> Answers { get; set; }
    }
}
