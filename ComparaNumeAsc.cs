using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class ComparaNumeAsc : IComparer<Student>
    {
        public int Compare(Student s1, Student s2) { return s1.Nume.CompareTo(s2.Nume); }
    }
}
