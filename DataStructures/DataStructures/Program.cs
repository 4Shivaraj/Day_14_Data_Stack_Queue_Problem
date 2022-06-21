﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome To Data Structures Problems");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedLists = new LinkedLists();

            //UC-1
            //Node node1 = new Node(56);
            //Node node2 = new Node(30);
            //Node node3 = new Node(70);
            //node1.next = node2;
            //node2.next = node3;
            //linkedLists.Head = node1;
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            //////UC-2
            ////linkedLists.AddNode(70);
            ////linkedLists.AddNode(30);
            ////linkedLists.AddNode(56);
            ////linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            //////UC-3
            ////linkedLists.AppendNode(56);
            ////linkedLists.AppendNode(30);
            ////linkedLists.AppendNode(70);
            ////linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-4
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(70);
            //linkedLists.InsertNode(30, 56);
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-5
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //Console.WriteLine("Delete First element");
            //linkedLists.DeleteNodeAtFirst();
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-6
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //Console.WriteLine("Delete Last element");
            //linkedLists.DeleteNodeAtLast();
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-7
            //Node node1 = new Node(56);
            //Node node2 = new Node(30);
            //Node node3 = new Node(70);
            //node1.next = node2;
            //node2.next = node3;
            //linkedLists.Head=node1;
            //Console.WriteLine("Search For Node value 30");
            //linkedLists.Display();
            //if (linkedLists.Search(30))
            //{
            //    Console.WriteLine("\nNode with value 30 is available in Linked list");
            //}
            //Console.WriteLine("\n-------------------------------");


            //UC-8
            //Console.WriteLine("Add Node After Node value 30 ");
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //linkedLists.InsertNode(40,30);
            //linkedLists.Display();

            ////UC-9
            //Console.WriteLine("Delete From Middle");
            //linkedLists.Display();
            //linkedLists.DeleteNodeWithdata(40);
            //linkedLists.Display();


            //Stack & Queue
            //UC-1
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.DisplayStack();
            stack.Top();


        }
    }
}


//UC-1
//Ability to create a Stack of 56->30->70
//- Use LinkedList to do the Stack Operations
//- Here push will internally call add method on LinkedList.
//- So 70 will be added first then 30 and then 56 to make 56 on top of the Stack

//Result
//Added 70 at start of the linkedlist
// Added 30 at start of the linkedlist
// Added 56 at start of the linkedlist
//Stack:
// Linked List :
//56-> 30-> 70