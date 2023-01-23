//using Arrays_Example;

var input = 3;

var numbers = new Arrays_Example01.Array(input);
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.Insert(50);
numbers.Print();

numbers.RemoveAt(3);
numbers.Print();

Console.WriteLine(numbers.IndexOf(10));
Console.WriteLine(numbers.IndexOf(40));

Console.WriteLine();
Console.WriteLine(numbers.Max());
Console.WriteLine();

numbers.InsertAt(100, 1);
numbers.Print();

numbers.Reverse();
numbers.Print();

var otherInput = 1;
var otherArray = new Arrays_Example01.Array(otherInput);
otherArray.Insert(40);
otherArray.Print();

