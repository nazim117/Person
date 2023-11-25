using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get { return name; } private set { name = value; } }
        public virtual int Age 
        {
            get { return age; } 

            private set 
            {
                if (value >= 0)
                {
                    age = value; 
                }
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
            this.Name,
           this.Age));
            return stringBuilder.ToString();
        }

    }
}
