using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class ComparaNumeDesc : IComparer<Student>
    {
        public int Compare(Student s1, Student s2) { return s2.Nume.CompareTo(s1.Nume); }
    }
}
