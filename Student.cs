using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Student : Persoana
    {
        private byte anStudiu;
        private byte[] nota = new byte[5];
        private float medie;

        public byte AnStudiu
        {
            get { return anStudiu; }
        }
        public float Medie
        {
            get
            {
                medie = 0f;
                for (int i = 0; i < 5; i++) medie += nota[i];
                medie /= 5f;
                return medie;
            }
        }
        public byte getNote(int i) { return nota[i]; }

        public Student(string nume, byte varsta, byte an, byte[] nota)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.anStudiu = an;
            this.nota = nota;
            medie = Medie;
        }

        public override string ToString()
        {
            return $"Nume: {nume}\tVârstă: {varsta}\tAn studiu: {anStudiu}\tNote: {nota[0]}, {nota[1]}, {nota[2]}, {nota[3]}, {nota[4]}\tMedia: {medie}";
        }
    }
}
