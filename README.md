# Unhandled Exception During Exception Handling in C#

This repository demonstrates a common, yet easily overlooked, error in C# exception handling: an exception thrown within the `catch` block that masks the original exception.  The original exception's context is lost, making debugging significantly more difficult.

The `bug.cs` file shows the flawed code, and `bugSolution.cs` offers a more robust solution that addresses this issue. The solution includes logging of exceptions for better troubleshooting.