using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge.Concrete
{
    public class CollegeProfessor: Teacher
    {
        public CollegeProfessor(ISubject subject):base(subject)
        {            
        }
        public override void TechSubject()
        {
            Console.Write("College Professor: ");
            _subject.Teach();
        }
    }
}
