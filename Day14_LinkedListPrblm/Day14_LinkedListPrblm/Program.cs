﻿using Day14_LinkedListPrblm;

Console.WriteLine("Welcome to Data Structure Linked List :\n");
LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(70);
Console.WriteLine("enter the data which you want to search in Linked List ");
int data = int.Parse(Console.ReadLine());
Console.WriteLine(list.Search(data));