using MyLib;
using System;
using System.Reflection;

namespace ConsoleApp_A
{
  public  class MyClass
    {
        public MyClass()
        {
            Name = "Empty";
            Number = 0;
        }

        public MyClass(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        private int Sum(int x, int y)
        {
            return x + y;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //var test = new TestClass();
            //test.Test();
            //var assembly = Assembly.GetExecutingAssembly();
            //var types = assembly.GetTypes();
            //foreach (var type in types)
            //{
            //    Console.WriteLine(type);
            //    foreach (var item in type.GetMembers())
            //    {
            //        Console.WriteLine("" + item);
            //    }
            //}

            //var name = "Vladimir";
            //object obj = name;
            //var type = obj.GetType();
            //Console.WriteLine(type);

            var obj = Activator.CreateInstance("ConsoleApp_A", "MyClass").Unwrap();
            Console.WriteLine(obj.GetType().GetMethod("Hello"));
            var method = obj.GetType().GetMethod("Hello");
            method.Invoke(obj, new object[] { "Vladimir" });
        }
    }
}
