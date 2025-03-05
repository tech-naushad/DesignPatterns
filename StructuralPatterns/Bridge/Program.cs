using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    //  Client Codes
    class Program
    {
        static void Main()
        {
            var primaryTeacher = new PrimaryTeacher(new Math());
            primaryTeacher.TechSubject();

            var highSchoolTeacher = new HighSchoolTeacher(new Science());
            highSchoolTeacher.TechSubject();

            var collegeProfessor = new CollegeProfessor(new History());
            collegeProfessor.TechSubject();
        }
    }
}
