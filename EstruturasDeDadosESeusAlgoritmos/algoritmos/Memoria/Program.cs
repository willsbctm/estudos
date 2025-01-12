// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = new No();
Console.WriteLine(a.GetHashCode());

var b = a;
Console.WriteLine(b.GetHashCode());

var c = new No();
b = c;
Console.WriteLine(c.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(a.GetHashCode());

class No{

}