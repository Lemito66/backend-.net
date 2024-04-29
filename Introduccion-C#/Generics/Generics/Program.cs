// See https://aka.ms/new-console-template for more information

var numbers = new MyList<int>(5);
var names = new MyList<string>(5);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

Console.WriteLine(numbers.GetContent());



public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _list = new List<T>(); // Initialize the list
        _limit = limit; // Set the limit
    }

    public void Add(T item)
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var item in _list)
        {
            content += item + ", ";
        }
        return content.ToString();
    }
}
