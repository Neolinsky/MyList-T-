using System;
using System.Text;

namespace ConsoleApp21
{
	class Program 
	{
		static void Main(string[] args)
		{
			MyList<int> spisok = new MyList<int>();

			spisok.Add(new Node<int>(10));
			spisok.Add(new Node<int>(28));
			spisok.Add(new Node<int>(32));
			spisok.Add(new Node<int>(22));
			spisok.Add(new Node<int>(12));

			spisok.PushFront(new Node<int>(100));


			Console.WriteLine();

			spisok.Print();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine(spisok.Get(1)); 

		}
	}
}
