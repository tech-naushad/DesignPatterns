using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public abstract class Teacher
    {
        protected readonly ISubject _subject;

        protected Teacher(ISubject subject)
        {
            _subject = subject;
        }
        public abstract void TechSubject();
    }
}
