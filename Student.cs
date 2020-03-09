using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    class Student
    {
        string Nume;
        string Prenume;
        string Grupa;
        int Nota;
        string Promovat;
        public Student()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            Grupa = string.Empty;
            Nota = 0;
            Promovat = "nu";
        }
        public Student(string _Nume,string _Prenume,string _Grupa,int _Nota)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            Grupa = _Grupa;
            Nota = _Nota;
            if (Nota >= 5)
                Promovat = "da";
            else Promovat = "nu";
        }
        public string Info()
        {
            return string.Format("Nume: {0}\nPrenume: {1}\nGrupa: {2}\nNota: {3}\nPromovat: {4}\n", Nume, Prenume, Grupa, Nota, Promovat);
        }
    }
}
