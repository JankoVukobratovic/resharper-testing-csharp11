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

        [Test<Nullable<int>>] public int MyInt;

        [Test<int[]>]
        public void MyFunction()
        {
        }

        [TestAttributeWithClassConstraint<Nullable<int>]
        public void MyFunction5()
        {
        }
    }

    //Invalid usages

    [TestAttribute<>]
    class BrokenClass { }

    [TestAttributeWithEnumerableConstraint<int>]
    class ValidClass
    {
    }
}
