namespace stack;

public class StackOperations
{
    public static void Main(string[] args)
    {
        var MyStack = new Stack<int>(5);

        MyStack.Push(1);
        MyStack.Push(2);
        MyStack.Push(3);
        MyStack.Push(4);
        MyStack.Push(5);

        foreach (var stack in MyStack) Console.WriteLine(stack + " ");

        Console.WriteLine(MyStack.Pop());
        Console.WriteLine(MyStack.Peek());

        Console.WriteLine(MyStack.Contains(5));
    }
}