namespace CalculatorMatsko;

public class Queue
{
    private const int Capacity = 50;
    private string[] _array = new string[Capacity];
    private int _head;
    private int _tail;

    public void Enqueue(string item)
    {
        if (_tail == _array.Length)
        {
            throw new Exception("queue is full");
        }

        _array[_tail] = item;
        _tail++;
    }

    public string Dequeue()
    {
        string returnItem = _array[_head];
        _head++;
        return returnItem;

    }
    public void Write()
    {
        Console.WriteLine("queue is:");
        for (int i = _head; i < _tail; i++) 
        {
            Console.WriteLine(_array[i]);
        }
    }

}