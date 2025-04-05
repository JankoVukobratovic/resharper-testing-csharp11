C# 11 Generic Attributes - Testing Report
This repository contains tests for the Generic Attributes feature introduced in C# 11. The goal of this testing was to verify the behavior of generic attributes in different contexts, both in the C# compiler and in ReSharper.

Tested Features
1. Valid Use of Generic Attributes
I tested the ability to correctly apply generic attributes to various targets such as classes, methods, properties, fields, and parameters. The following were tested:

Attributes Applied to Classes

Example: [TestAttribute<int>] on a class.

Expected: The compiler should allow attributes to be applied to a class without issues.

Attributes Applied to Methods

Example: [TestAttribute<string>] on a method.

Expected: The compiler should allow attributes to be applied to methods without issues.

Attributes Applied to Properties

Example: [TestAttribute<double[]>] on a property.

Expected: The compiler should allow attributes on properties of arrays, nullable types, and other valid types.

Attributes Applied to Fields

Example: [TestAttribute<Nullable<bool>>] on a field.

Expected: The compiler should allow attributes on fields with complex types, including nullable types.


2. Invalid Attribute Application
I also tested invalid usages of generic attributes. The following cases were expected to produce compile-time errors:

Open Generics

Example: [TestAttribute<>] with no type argument.

Expected: The compiler should throw an error, as open generics are not valid for attributes.

Attributes with Invalid Types (Wrong Constraints)

Example: Applying [TestAttributeWithConstraints<int>] when TestAttributeWithConstraints<T> has a where T : IEnumerable constraint.

Expected: The compiler should throw an error if the type parameter doesn't satisfy the constraint.

Attributes Applied to Invalid Targets

3. Handling Complex Types
I tested the use of more complex types as type arguments for generic attributes:

Nullable Types

Example: [TestAttribute<Nullable<int>>]

Expected: The compiler should allow nullable types as valid type arguments for attributes.

Array Types

Example: [TestAttribute<int[]>]

Expected: The compiler should allow array types to be used as generic arguments for attributes.

4. Generic Constraints on Attributes
I verified the behavior of generic attributes that have constraints:

Constraints on Generic Attributes

Example: [TestAttributeWithConstraints<string>] where T implements IEnumerable.

Expected: The compiler should enforce constraints and throw an error when an invalid type is used.

5. ReSharper (IDE) Behavior
I tested several ReSharper features related to generic attributes:

Code Completion:

Test: When typing [TestAttribute<], ReSharper should suggest possible types.

Expected Behavior: ReSharper should provide valid suggestions based on the context.

Quick Fixes:

Test: When applying an invalid generic attribute (e.g., [TestAttribute<>]), ReSharper should suggest quick fixes to resolve the issue.

Expected Behavior: ReSharper should suggest correcting the attribute application or replacing it with a valid type.

Find Usages:

Test: Use ReSharper's "Find Usages" feature on the generic attribute.

Expected Behavior: ReSharper should highlight all usages of the attribute throughout the codebase.

Refactoring:

Test: Rename the generic attribute and check that it propagates correctly across the project.

Expected Behavior: ReSharper should handle renaming the attribute and all its usages in the codebase.

Error Highlighting:

Test: Verify that ReSharper flags invalid uses of attributes (e.g., open generics or applying an attribute to an unsupported target).

Expected Behavior: ReSharper should highlight invalid usages with a red underline and provide the appropriate error message.

Navigation:

Test: Navigate between the attribute definition and its usage in the code.

Expected Behavior: ReSharper should allow easy navigation to and from attribute definitions.

Issues Encountered
1. Compiler Issues
Open Generics: The compiler correctly throws an error for applying open generics ([TestAttribute<>]), which is expected.

Constraint Violations: The compiler correctly enforces constraints, and invalid types result in compile-time errors. No issues were found here.

2. ReSharper Issues
Quick Fixes for Open Generics: ReSharper sometimes fails to suggest fixes for open generic attributes, although the compiler correctly flags the issue.

Conclusion
The testing of C# 11 Generic Attributes showed that both the C# compiler and ReSharper handled most scenarios correctly. While the compiler performed as expected, ReSharper could improve in terms of quick fixes for open generics. Should be monitored for improvements in future versions of the tool.