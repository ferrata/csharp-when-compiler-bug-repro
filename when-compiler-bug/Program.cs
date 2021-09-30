using System.Collections.Generic;
using System.Linq;

namespace when_compiler_bug
{
    internal interface IBaseInterface
    {
    }

    internal class ParentClass : IBaseInterface
    {
        public bool BoolProperty => false;

        public bool DummyCondition() => false;
    }

    internal class ClassA : ParentClass
    {
        public List<object> ListProperty => new List<object>();
    }

    internal class Reproduce
    {
        public void Run(IBaseInterface baseInterface)
        {
            switch (baseInterface)
            {
                case ParentClass { BoolProperty: false } c
                    when c.DummyCondition():
                    // ...
                    break;
                case ClassA box when box.ListProperty.Any(_ => false):
                    // ...
                    break;
                case ParentClass { BoolProperty: false }:
                    // ...
                    break;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            new Reproduce().Run(new ClassA());
        }
    }
}