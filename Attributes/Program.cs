using System;
using System.Diagnostics;

namespace Attributes
{
    [DebuggerDisplay("Name={Name,nq}, id={Id,h}")]
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Person(id: {Id}, name: {Name})";
        }

        [Obsolete("Please don't use this function anymore, use funcNew instead", true)]
        public void func() { }

        public void funcNew() { }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Person p1 = new() { Id = 1234, Name = "Avi Man" };
            Console.WriteLine(p1);
            
            //p1.func();

        }
    }
}
