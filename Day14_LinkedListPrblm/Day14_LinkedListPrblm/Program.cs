﻿using Day14_LinkedListPrblm;

Console.WriteLine("Welcome to Data Structure Linked List :\n");
LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(70);
list.Display();
Console.WriteLine();
Node node = new Node(40);
list.InsertAtParticularPosition(30, node);
Console.Write("\n After Inserted 40 in b/w 30 and 70 :\n Linked List : ");
list.Display();
