using System;
using System.Collections;

namespace ConsoleApp2.Attributes
{
    class TestAttribute<T> : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    class TestPropertyAttribute<T> : TestAttribute<T>
    {
    }


    [AttributeUsage(AttributeTargets.Class)]
    class TestClassAttribute<T> : TestAttribute<T>
    {
    }


    [AttributeUsage(AttributeTargets.Field)]
    class TestFieldAttribute<T> : TestAttribute<T>
    {
    }


    [AttributeUsage(AttributeTargets.Method)]
    class TestMethodAttribute<T> : TestAttribute<T>
    {
    }

    public class TestAttributeWithEnumerableConstraint<T> : Attribute where T : IEnumerable
    {
    }

    public class TestAttributeWithClassConstraint<T> : Attribute where T : class 
    {
    }
}
