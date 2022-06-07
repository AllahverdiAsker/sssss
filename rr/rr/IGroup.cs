using System;
using System.Collections.Generic;
using System.Text;

namespace rr
{
    interface IGroup
    {
        
        Student[] students { get; set; }
        
        void AddStudent(Student student);
        void CalcGroupAverage();

        



    }
}
