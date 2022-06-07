using System;
using System.Collections.Generic;
using System.Text;

namespace rr
{
    class Student
    {

        public Student()
        {

            TotalCount++;
            TotalCount = No;


        }

        public int No;
        private double _point;
        public double Point
        {
            get => _point;
            set
            {
                PointCheck(_point);
                Point = _point;
            }
        }
        public static bool PointCheck(double _point)
        {
            if (_point != null)
            {
                if (_point > 0 && _point < 101)
                    return true;
            }
            return false;

        }

        public static int TotalCount;


        private string _fullname;
        public string Fullname
        {
            get => _fullname;


            set
            {
                FullNameCheck(_fullname);
                Fullname = _fullname;
            }
        }


        public static bool FullNameCheck(string _fullname)
        {

            if (_fullname.Length == 2)
            {
                for (int i = 0; i < _fullname.Length; i++)
                {
                    if (char.IsUpper(_fullname[0]) && char.IsUpper(_fullname[1]))
                    {

                        return true;
                    }
                    return false;
                }

            }

            return false;


        }



    }







}
