using ConsoleApp2.Attributes;

namespace ConsoleApp2.Tests
{
    public class TargetTypeAttributeUsageTests
    {
        // Test: Applying TestPropertyAttribute to a property
        [TestProperty<int>]
        public int PropertyWithTestPropertyAttribute { get; set; }

        // Test: Applying TestClassAttribute to a class
        [TestClassAttribute<string>]
        class ClassWithTestClassAttribute { }

        // Test: Applying TestFieldAttribute to a field
        [TestFieldAttribute<double>]
        public double FieldWithTestFieldAttribute;

        // Test: Applying TestMethodAttribute to a method
        [TestMethodAttribute<float>]
        public void MethodWithTestMethodAttribute() { }

        // Test: Applying TestPropertyAttribute to a property in a class
        class ClassWithProperty
        {
            [TestPropertyAttribute<int>]
            public int MyProperty { get; set; }
        }

        // Test: Applying TestFieldAttribute to a field in a class
        class ClassWithField
        {
            [TestFieldAttribute<bool>]
            public bool MyField;
        }

        // Test: Applying TestMethodAttribute to a method in a class
        class ClassWithMethod
        {
            [TestMethodAttribute<decimal>]
            public void MyMethod() { }
        }

        // Test: Applying TestClassAttribute to a generic class (valid usage)
        [TestClassAttribute<double>]
        class GenericClassWithTestClassAttribute<T> { }

        // Invalid: Trying to apply TestPropertyAttribute to a method (should fail)
        // [TestPropertyAttribute<int>]
        public void InvalidMethodWithTestProperty() { }

        // Invalid: Trying to apply TestFieldAttribute to a method (should fail)
        // [TestFieldAttribute<string>]
         public void InvalidMethodWithTestField() { }

        // Invalid: Trying to apply TestMethodAttribute to a field (should fail)
        //[TestMethodAttribute<double>]
        public double InvalidFieldWithTestMethod;
    }
}
