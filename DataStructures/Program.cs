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
Console.WriteLine("linked Stack place");
Console.WriteLine(linkedListStack.Pop());
Console.WriteLine(linkedListStack.GetTop());
Console.WriteLine(linkedListStack.Length);

// test stack algorithms

Console.WriteLine(StackAlgo.IsBalancedParanthases("(2+5) + [44]"));
Console.WriteLine(StackAlgo.IsBalancedParanthases("({{}})["));

// queue section
// cicular array queue section

CircularArrayQueue<int> circularArrayQueue = new CircularArrayQueue<int>(6);
circularArrayQueue.Enqueue(2);
circularArrayQueue.Enqueue(3);
circularArrayQueue.Enqueue(4);
Console.WriteLine("queue sec -------------------------------------------");
Console.WriteLine(circularArrayQueue.Dequeue());
Console.WriteLine(circularArrayQueue.GetFront());
Console.WriteLine(circularArrayQueue.GetRear());
circularArrayQueue.Dequeue();
circularArrayQueue.Dequeue();
circularArrayQueue.Enqueue(5);
Console.WriteLine(circularArrayQueue.GetFront());
Console.WriteLine(circularArrayQueue.GetRear());
Console.WriteLine(circularArrayQueue.QueueSearch(5));
Console.WriteLine("linkedQueue section ..............");

LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
linkedQueue.Enqueue(2);
linkedQueue.Enqueue(3);
linkedQueue.Enqueue(4);
linkedQueue.Dequeue();
linkedQueue.Dequeue();
linkedQueue.Dequeue();
linkedQueue.Enqueue(5);
// LinkedList space
Console.WriteLine("Linked list section...........................");
CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
customLinkedList.InsertAtFirst(2);
customLinkedList.InsertAtFirst(3);
customLinkedList.InsertAtFirst(4);
customLinkedList.InsertAtLast(5);
customLinkedList.InsertAtLast(6);
customLinkedList.InsertAtPosition(3, 7);