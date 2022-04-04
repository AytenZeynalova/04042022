using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryClass
{
   public class Student
    {


        public Student(string fullname, string groupNo, byte age)
        {
            this.FullName = fullname;
            this.GroupNo = groupNo;
            this.Age = age;
        } 

        private string _groupno;

        private string _fullname;
        
        public byte Age { get; set; }

        public string GroupNo
        {
            get
            {
                return _groupno;
            }
            set
            {
                if (CheckGroupNo(value))
                    _groupno = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {

            }
        }

        public static bool CheckGroupNo(string str)
        {
            if(!String.IsNullOrEmpty(str) && str.Length == 4)
            {
                if(char.IsUpper(str[0])&& char.IsDigit(str[1]) && char.IsDigit(str[2]) && char.IsDigit(str[3]))
                {
                    return true;
                }
                return false;
            }
            return false;

        }
        public static bool CheckFullname(string name, string surname)
        {
            if(name+" "+ surname)
            {

            }
        }

    }
}
