using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Mage
    {
        public const int datebirth = 2004;
        private string gender;
        private string name;
        private int age;
        private int id;

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - datebirth;
            }
            set
            {
                age = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        
    }
}
