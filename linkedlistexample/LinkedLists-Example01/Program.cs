
var list = new LinkedLists_Example01.LinkedList();
Console.WriteLine($"Size: {list.Size()}");
list.AddLast(10);
list.AddLast(20);
list.AddLast(30);

list.AddFirst(5);

Console.WriteLine();
var array = list.ToArray();
PrintArray(array);

list.Reverse();
array = list.ToArray();
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Size: {list.Size()}");

Console.WriteLine(list.IndexOf(10));
Console.WriteLine(list.IndexOf(1000));
Console.WriteLine(list.Contains(20));
Console.WriteLine(list.Contains(1000));

list.RemoveFirst();
list.RemoveLast();
Console.WriteLine($"Size: {list.Size()}");

array = list.ToArray();
PrintArray(array);

Console.WriteLine();

static void PrintArray(int[] array)
{
    List<int> numbers = array.ToList();
    numbers.ForEach(Console.WriteLine);
}