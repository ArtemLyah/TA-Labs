using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TALab6
{
    public class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public int Key { get; set; }
        public Person(string surname, string name, string birthday)
        {
            Surname = surname;
            Name = name;
            Birthday = birthday;
            Key = CreateKey(surname);
        }
        public Person(string surname, string name) 
        { 
            Surname= surname;
            Name = name;
            Key = CreateKey(surname);
        }
        public Person() { }
        public int CreateKey(string surname)
        {
            int key = 0;
            byte[] b = Encoding.Unicode.GetBytes(surname);
            foreach (byte b2 in b) 
            {
                key += b2;
            }
            return key;
        }

    }
}
