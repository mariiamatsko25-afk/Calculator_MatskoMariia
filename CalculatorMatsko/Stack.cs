namespace CalculatorMatsko;

public class Stack
{
    private const int Capacity = 50;
    private string[] _array = new string[Capacity];
    private int count = 0;
    private int _pointer;

    public void Push(string value)
    {
        if (_pointer == _array.Length)
        {
            throw new Exception("stack overflowed");
        }

        _array[_pointer] = value;
        _pointer++;
        count++;
    }

    public string Pull()
    {
        if (_pointer == 0)
        {
            return null;
        }
        _pointer--;
        count--;
        var value = _array[_pointer];
        return value;
    }

    public string Peek()
    {
        if (_pointer == 0)
        {
            return null;
        }
        return _array[_pointer-1];
    }

    public int Count()
    {
        return count;
    }
}
