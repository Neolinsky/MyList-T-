using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
	public class Node<T>
	{
		public T value;
		public Node<T> next;
		public Node<T> prev;


		public static int Count;

		public Node(T value)
		{
			this.value = value;

		}

		public Node()
		{
			
		}



	}
}
