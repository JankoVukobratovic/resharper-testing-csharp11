using System;
using ConsoleApp2.Attributes;

namespace ConsoleApp2.Tests
{
    [TestAttribute<int>]
    class TestClass1
    {
    }

    class TestClass2
    {
        [TestAttribute<string>]
        void MethodWithGenericAttr()
        {
        }

        [TestAttribute<double[]>] public int MyProperty { get; set; }

        [TestAttribute<bool?>] public int MyField;

        public void Foo([TestAttribute<object>] int parameter)
        {
        }
    }

    //Invalid usages

    // [MyAttribute<>]
    // class BrokenClass { }

    [TestAttributeWithConstraint<string>]
    class ValidClass
    {
    }

    //[TestAttributeWithConstraint<int>]
    class InvalidClass
    {
    }
}
