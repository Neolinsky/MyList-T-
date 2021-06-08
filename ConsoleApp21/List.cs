using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
	class MyList<T> 
	{
		public Node<T> list;

		public Node<T> head;
		public Node<T> tail;

		public Node<T> prev;


		public void Add(Node<T> NewNode)
		{
			Node<T>.Count++;
			if(list != null)
			{
				GetLast().next = NewNode;

				GetLast().prev =  prev;

				tail = GetLast();
				prev = tail;
			
				return;
			}

			list = NewNode;
			head = list;
			tail = list;
			prev = list;
		
			
		}

		public Node<T> GetLast()
		{
			Node<T> current = list;
			while(current.next != null)
			{
				current = current.next;
			}
			return current;
		}

		public void Print()
		{		
			Node<T> Head = head;
			while(Head != null)
			{				
					Console.WriteLine(Head.value);
					Head = Head.next;				
			}
		}

		public void PrintBack()
		{
			Node<T> Tail = tail;
			while (Tail != null)
			{
				Console.WriteLine(Tail.value);
				Tail = Tail.prev;
			}
		}



		public void PushFront(Node<T> newNode)
		{
			Node<T> node = newNode;
			node.next = head;
			head.prev = node;
			head = node;
		}


	}
}
