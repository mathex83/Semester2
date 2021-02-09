using System.Collections.Generic;

namespace Assignments.AssignmentsDates.a2021_02_03
{
	public class Set<T> : ISet<T>
    {
        private List<T> elements = new List<T>();

        public int Count
        {
            get { return elements.Count; }
        }

        //hvis elem ik eksisterer så læg det ind.
        public void Add(T elem)
        {
            if (!Contains(elem)) elements.Add(elem);
        }

        public void Remove(T elem)
        {
            elements.Remove(elem);
        }

        public bool Contains(T elem)
        {
            return elements.Contains(elem);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        System.Collections.IEnumerator
            System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Add metoden vil kun lægge t ind, såfremt den ikke 
        /// allerede eksisterer i listen.
        /// Derfor kan vi producere en 'union' ud af 'this' instansens 
        /// elements og elements 
        /// fra det Set 'S' der passes ind
        /// </summary>
        /// <param name="S">Set, der skal laves en Union med</param>
        /// <returns>Set R, som er union af de to sæt af elementer</returns>


        //Laver et nyt set af typen T og kalder det R.
        //this er mængden A fra Program.cs,
        //S er mængden B.
        //Med denne metode tilføjes ikke eksisterende elementer
        public ISet<T> Union(ISet<T> S)
        {
            ISet<T> R = new Set<T>();
            foreach (T t in this) R.Add(t);
            foreach (T t in S) R.Add(t);
            return R;
        }

        /// <summary>
        /// Metoden returnerer fællesmængden af denne klasses mængde 
        /// og mængden S.
        /// </summary>    

        //returnerer tal der eksisterer i begge mængder/Sets
        public ISet<T> Intersect(ISet<T> S)
        {
            ISet<T> R = new Set<T>();
            foreach (T t in this) if (S.Contains(t)) R.Add(t);
            return R;
        }


        public ISet<T> Difference(ISet<T> S)
        {
            ISet<T> R = new Set<T>();
            foreach (T t in this) if (!S.Contains(t)) R.Add(t);
            return R;
        }
    }
}
