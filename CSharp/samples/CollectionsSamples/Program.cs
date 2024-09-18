// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var dictionary = new Dictionary<string, string>
{
    { "item1", "item2" }
};


var list = new List<string>
{
    "item1"
};

var queue = new Queue<string>();
queue.Enqueue("item1");
var itemQueue = queue.Dequeue();

var stack = new Stack<string>();
stack.Push("item1");
var itemStack = stack.Pop();


