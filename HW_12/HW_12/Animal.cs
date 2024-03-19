using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal abstract class Animal
    {
        protected string? name;
        protected int numOfLegs = 0;

        public void SetName (string name) 
        { this.name = name; }
        public string? GetName () 
        { return this.name; }

        public void SetNumberOfLegs (int legs) 
        {  this.numOfLegs = legs; }
        public int GetNumOfLegs () 
        {  return this.numOfLegs; }

        public abstract void DisplayAnimal();
    }
}
