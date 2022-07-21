﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedListPrblm
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next; 
            }
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        internal Node InsertAtParticularPosition(int PreviousData, Node Newdata)
        {
            Node temp = this.head;
            while (temp != null) //
            {
                while (temp.data == PreviousData)
                {
                    Node newnode = temp.next;
                    temp.next = Newdata;
                    temp.next.next = newnode;

                    break;
                }
                temp = temp.next;
            }
            return head;
        }
    }
}
