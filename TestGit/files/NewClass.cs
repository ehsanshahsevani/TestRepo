using System;
using System.Collections.Generic;
using System.Text;

namespace TestGit.files
{
    public class NewClass : ClassLibrary1.Class1
    {
        public NewClass(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
