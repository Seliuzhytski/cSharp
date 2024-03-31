using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_14
{
    internal class CustomStringEmptyExeption : Exception
    {
        public CustomStringEmptyExeption(string message) : base(message) { }
    }

    class Person
    {
        public string Name { get; set; }
       
        public Person (string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new CustomStringEmptyExeption("Заполните параметр Name!");
            }
            this.Name = name;
        }
    }
}
