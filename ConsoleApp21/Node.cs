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
		public int id;

		public void SetId(int id)
		{
			this.id = id;
		}


		public static int Count = 0;

		public Node(T value)
		{
			this.value = value;

		}

		public Node()
		{
			
		}



	}
}
