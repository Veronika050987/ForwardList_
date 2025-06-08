using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
    class Element
    {
		public int Data { get; set; }
		public Element pNext { get; set; }

		public Element(int data)
		{
			Data = data;
			pNext = null;
			Console.WriteLine($"EConstructor:\t{GetHashCode()}");
		}
		public Element(int data, Element pNext)
		{
			Data = data;
			this.pNext = pNext;
			Console.WriteLine($"EConstructor:\t{GetHashCode()}");
		}

		~Element()
		{
			Console.WriteLine($"EDestructor:\t{GetHashCode()}");
		}
	}
}
