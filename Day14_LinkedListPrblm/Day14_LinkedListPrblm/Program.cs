using Day14_LinkedListPrblm;

Console.WriteLine("Welcome to Data Structure Linked List :\n");
LinkedList list = new LinkedList();
Node node = new Node(30);
list.Add(56);
list.Add(70);
list.Display();
list.InsertAtParticularPosition(56, node);
Console.Write("\n After Inserted 30 in b/w 56 and 70 :\n Linked List : ");
list.Display();