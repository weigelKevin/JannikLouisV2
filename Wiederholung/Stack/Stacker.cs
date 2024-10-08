namespace Stack;

public class Stack<T>
{
    private List<T> stack { get; set; }

    public Stack(List<T> stack)
    {
        this.stack = stack;
    }

    public void Push(T input)
    {
        stack.Add(input);

        string result = string.Join(" ,", stack);
        Console.WriteLine(result);
    }

    public void Pop(int input)
    {
        for (int i = 0; i < input; i++)
        {
            stack.RemoveAt(stack.Count - 1);
        }
        string result = string.Join(" ,", stack);
        Console.WriteLine(result);
    }

    
}