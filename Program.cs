﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample32
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public void CounteParent()
            {
                Parent.counter++;
            }
            public Parent() {  Console.WriteLine("Parent()");}
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }

        class Child : Parent
        {
            public void CountChilde()
            {
                Child.counter++;
            }
            public Child() : base(10)
            {
                Console.WriteLine("Child():base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Parent parent = new Parent();
            Child child = new Child();

            parent.CounteParent();
            child.CounteParent();
            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

        }
    }
}
