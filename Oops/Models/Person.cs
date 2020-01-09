using System.Collections.Generic;

namespace Oops.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Attendance> Attendance { get; set; }
    }
}
