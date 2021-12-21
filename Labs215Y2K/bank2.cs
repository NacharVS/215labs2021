using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
        abstract class Person
        {
            private int _day_birthday, _month_birthday, _year_birthday;
            private string _surname;
            private string _name;
            private static int _id;
            private string _Phone;
            public string Phone
            {
                get
                {
                    return _Phone;
                }
                set
                {
                    _Phone = value;
                }
            }
            public int day_birthday
            {
                get
                {
                    return _day_birthday;
                }
                set
                {
                    _day_birthday = value;
                }
            }
            public int month_birthday
            {
                get
                {
                    return _month_birthday;
                }
                set
                {
                    _month_birthday = value;
                }
            }
            public int year_birthday
            {
                get
                {
                    return _year_birthday;
                }
                set
                {
                    _year_birthday = value;
                }
            }
            public string SurName
            {
                get
                {
                    return _surname;
                }
                set
                {
                    _surname = value;
                }
            }
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public int ID
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }
        }
    
}
