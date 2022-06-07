using System;
using System.Collections.Generic;
using System.Text;

namespace rr
{
    class GroupClass : IGroup
    {
        public GroupClass()
        {
            Totals++;
            Totals = GroupNo;
        }
        private int _studentlimit;
        public int StudentLimit
        {
            get => _studentlimit;
            set => _studentlimit = value;
        }
       
        
        public int GroupNo;
        public static int Totals;
        private Student[] _students;
        public Student[] Students
        {
            get => _students;
            set => _students = value;
        }
        public Student[] students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddStudent(Student student)
        {
            for(int i = 0; i < _students.Length; i++)
            {
                if (_studentlimit > _students.Length && _students[i] != student)
                {
                    Array.Resize(ref _students, _students.Length + 1);
                    student = _students[_students.Length - 1];
                }
            }
            
            
        }

        public void CalcGroupAverage()
        {
            double average = 0;
            for(int i = 0; i < Students.Length; i++)
            {
                average += Students[i].Point;
            }
        }

        public bool GetStudentsByPoint(int max,int min)
        {
            
            Student[] newStudents = new Student[0];
            for(int i = 0; i < Students.Length; i++)
            {
                if(Students[i].Point>min&& Students[i].Point <= max)
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[i] = Students[i];
                    return true;
                }
                return false;
            }
            return false;
        }

       
        
           
        }
    
}
