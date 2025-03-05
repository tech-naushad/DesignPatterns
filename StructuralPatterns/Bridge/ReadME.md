## What is the Bridge Pattern?
Decouples an abstraction from its implementation so that both can evolve independently. 
It helps in avoiding a permanent binding between an abstraction and its implementation.

## Real-Life Example: Teacher and subject
A Teacher teaches different subjects, and a Student learns those subjects.
Instead of tightly coupling Teachers to specific Subjects, we separate them into two independent hierarchies:

Teacher (Abstraction) → PrimaryTeacher, HighSchoolTeacher, CollegeProfessor
Subject (Implementation) → Math, Science, History


## Benefits of Using Bridge  Pattern
✅ Decouples Teachers from Subjects → A teacher can teach any subject without modifying their class.
✅ Easier to Extend → You can add more teachers or subjects independently.
✅ Avoids Class Explosion → Without the Bridge pattern, we might have classes like PrimaryMathTeacher, 
HighSchoolScienceTeacher, etc.