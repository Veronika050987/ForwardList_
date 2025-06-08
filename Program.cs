using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
    class Program
    {
        static void Main(string[] args)
        {
			ForwardList stack = new ForwardList();
			stack.Push(3);
			stack.Push(5);
			stack.Push(8);
			stack.Push(13);

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("\nСодержимое стека:");
			stack.Print();
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"\nНачальный (первый) элемент стека: \n{stack.Peek()}");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"\nУдалён элемент: \n{stack.Pop()}");
			Console.WriteLine($"\nУдалён элемент: \n{stack.Pop()}");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("\nСодержимое стека после удаления элементов:");
			stack.Print();
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("\nИдёт очищение стека...");
			stack.Clear();
			Console.ResetColor();

			Console.WriteLine("\nСодержимое стека после очистки:");
			stack.Print();

			Console.ReadKey();
		}
    }
}
