using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_03
{
	public interface IDatastruct<T> : IEnumerable<T>
	{
		int Count { get; }
		bool Contains(T elem); void Clear();
		T[] ToArray();
	}
}
