﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_03
{
	class CollectionClass
	{
		// Interface, som definerer en mængde.
		// Interfacet definerer iterator mønsteret. 
		public interface ISet<T> : IEnumerable<T>
		{
			// Angiver antallet af elementer i mængden.
			int Count { get; }
			// Tilføjer et element til mængden, hvis den ikke allerede er der.
			void Add(T elem);
			// Fjerner et element fra mængden, hvis elementet er i mængden. 
			void Remove(T elem);
			// Returnerer true, hvis et element er i mængden. 
			bool Contains(T elem);
			// Returnerer foreningsmængden af denne mængde og mængden S. 
			ISet<T> Union(ISet<T> S);
			// Returnerer fællesmængden af denne mængde og mængden S. 
			ISet<T> Intersect(ISet<T> S);
			// Returnerer mængdedifferencen af denne mængde og mængden S. 
			ISet<T> Difference(ISet<T> S);
		}
	}
}

