using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
    class ForwardList
    {
		Element Head { get; set; }

		public int Length { get; private set; }

		public ForwardList()
		{
			Head = null;
			Length = 0;
			Console.WriteLine($"LConstructor:\t{GetHashCode()}");
		}

		~ForwardList()
		{
			Head = null;
			Length = 0;
			Console.WriteLine($"LDestructor:\t{GetHashCode()}");
		}

		public void Clear()
		{
			while (Head != null)
			{
				PopFront();
			}
		}

		public void Push(int Data)//добавление элементов с начала стека
		{
			Head = new Element(Data, Head);
			Length++;
		}

		public int? Pop() //int? означает, что метод Pop() может возвращать либо целочисленное значение (представляющее данные,
						  //которые были извлечены из стека),
						  //либо значение null (представляющее тот факт, что стек был пуст и извлекать было нечего).
		{
			if (Head == null)
			{
				return null;
			}

			int poppedData = Head.Data;
			Head = Head.pNext;  // удаление элемента из списка, память регулируется с помощью GC
			Length--;
			return poppedData;
		}

		public int? Peek()//возвращает элемент из начала списка
		{
			if (Head == null)
			{
				return null;
			}

			return Head.Data;
		}

		public void Print()
		{
			for (Element Temp = Head; Temp != null; Temp = Temp.pNext)

				Console.Write($"{Temp.Data}\t");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"\nКоличество элементов списка: \n{Length}");
			Console.ResetColor();
		}

		private void PopFront() // вспомогательная функция для очистки списка
		{
			if (Head != null)
			{
				Head = Head.pNext;   // удаление элемента из списка, память регулируется с помощью GC
				Length--;
			}
		}
	}
}
