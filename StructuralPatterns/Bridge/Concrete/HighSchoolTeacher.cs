using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge.Concrete
{
    public class HighSchoolTeacher : Teacher
    {
        public HighSchoolTeacher(ISubject subject):base(subject)
        {            
        }
        public override void TechSubject()
        {
            Console.Write("High School Teacher: ");
            _subject.Teach();
        }
    }
}
