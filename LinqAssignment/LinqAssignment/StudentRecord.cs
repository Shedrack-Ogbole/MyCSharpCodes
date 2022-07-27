using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class StudentRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public StudentRecord(int id,string firstname,string surname)
        {
            Id = id;
            FirstName = firstname;
            Surname = surname;
        }
        public StudentRecord()
        {

        }

    }
}
