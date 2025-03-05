using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge.Concrete
{
    public class PrimaryTeacher : Teacher
    {
        public PrimaryTeacher(ISubject subject):base(subject)
        {            
        }
        public override void TechSubject()
        {
            Console.Write("Primary School Teacher: ");
            _subject.Teach();
        }
    }
}
