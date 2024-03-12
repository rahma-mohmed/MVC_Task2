using System.ComponentModel.DataAnnotations.Schema;

namespace Task2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int minDegree { get; set; }
        [ForeignKey("Department")]
        public int Dept_id { get; set; }
    }
}
