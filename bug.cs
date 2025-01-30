public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Some code here that might throw an exception
        try
        {
            // ...
        }
        catch (Exception ex)
        {
            // Handle exception.  But what if the exception causes another exception during handling?
            // ... more code that could fail
            throw; // Re-throwing without any additional context
        }
    }
}