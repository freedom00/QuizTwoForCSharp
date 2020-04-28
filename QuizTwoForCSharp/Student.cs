using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTwoForCSharp
{
    internal class Student
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool isAdded { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student(int id, string name, bool isAdded) : this(id, name)
        {
            this.isAdded = isAdded;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}", Name);
        }
    }
}