using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_03
{
	public interface IBuffer<T> : IDatastruct<T>
	{
		bool IsFull { get; }
		bool IsEmpty { get; }
		int Size { get; }
		void Add(T elem);
		T Remove();
	}
}
