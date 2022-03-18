using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Student
    {
        public string Name { get; set; }
        public string gender { get; set; }
        public string haircolor { get; set; }
        public int age { get; set; }
        public string hobbi { get; set; }

        public string result { get; set; }


        public string StudAdd(Student s)
        {
            if (s.Name == Name) return "there is only 1 exemplar";
            else if (s.gender == gender) return "it can be strange, from different point of view.. ";
            else return "good pair keKW";

            // i think there is no sense in other code

        }
    }
}
