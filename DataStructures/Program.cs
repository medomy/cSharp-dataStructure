// See https://aka.ms/new-console-template for more information
using DataStructures.algorithms;
using DataStructures.data;

Console.WriteLine("Hello, World!");

CustomStack<int> customStack = new CustomStack<int>(5);

customStack.Push(2);
customStack.Push(3);
customStack.Push(4);
int popedVal = customStack.Pop();

Console.WriteLine(popedVal);
Console.WriteLine(customStack.GetTop());

// linkedList stack try

LinkedListStack<int> linkedListStack= new LinkedListStack<int>();

linkedListStack.Push(1);
linkedListStack.Push(2);
linkedListStack.Push(3);
Console.WriteLine(linkedListStack.Pop());
Console.WriteLine(linkedListStack.GetTop());
Console.WriteLine(linkedListStack.Length);

// test stack algorithms

Console.WriteLine(StackAlgo.IsBalancedParanthases("(2+5) + [44]"));
Console.WriteLine(StackAlgo.IsBalancedParanthases("({{}})["));