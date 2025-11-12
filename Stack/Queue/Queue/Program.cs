namespace Queue;

public class Queue_Operations
{
    public static void Main(string[] args)
    {
        var Queue = new Queue<int>();

        Queue.Enqueue(1);
        Queue.Enqueue(2);
        Queue.Enqueue(3);
        foreach (var n in Queue) Console.WriteLine($"Initial Queue:{n}");

        var nDeQueue = Queue.Dequeue();
        Console.WriteLine(nDeQueue);
    }
}