using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignments.AssignmentsDates.a2021_02_03
{
	public class SetClass
	{
        private static Random rand = new Random();
        
        private static readonly a2021_02_03.SetClassFiles.SetClassWindow1 rw1 = new a2021_02_03.SetClassFiles.SetClassWindow1();
        private static readonly a2021_02_03.SetClassFiles.SetClassWindow2 rw2 = new a2021_02_03.SetClassFiles.SetClassWindow2();
        private static readonly a2021_02_03.SetClassFiles.SetClassWindow3 rw3 = new a2021_02_03.SetClassFiles.SetClassWindow3();

        // Udfører de tre testmetoder
        public void SetClassRunner()
        {
            Test1();
            Test2(10000);
            Test3(100000);
        }

        // Opretter en mængde A med 15 tilfældige elementer mellem 20 og 50
        // Opretter en mængde B med 15 tilfældige elementer mellem 20 og 50
        // Printer A
        // Printer B
        // Printer foreningsmængden af A og B
        // Printer fællesmængden af A og B
        // Printer mængdedifferencen mellem A og B
        private static void Test1()
        {
            ISet<int> A = Create(15, 20, 50); // new Set<int>() { 1 }; 
            ISet<int> B = Create(15, 20, 50); // new Set<int>() { 1 };
            Print(A);
            Print(B);
            Print(A.Union(B));
            Print(A.Intersect(B));
            Print(A.Difference(B));
        }

        // Opretter en mængde A med n tilfældige elementer mellem n og 3n
        // Opretter en mængde B med n tilfældige elementer mellem n og 3n
        // Printer antallet af elementer i foreningsmængden
        // og hvor lang tid det har taget at danne foreningsmængden
        // Printer antallet af elementer i fællesmængden
        // og hvor lang tid det har taget at danne fællesmængden
        // Printer antallet af elementer i mængdedifferencen
        // og hvor lang tid det har taget at danne mængdedifferencen
        private static void Test2(int n)
        {
            ISet<int> A = Create(n, n, 3 * n);
            ISet<int> B = Create(n, n, 3 * n);
            long t1 = GetTime();
            int n1 = A.Union(B).Count;
            long t2 = GetTime();
            int n2 = A.Intersect(B).Count;
            long t3 = GetTime();
            int n3 = A.Difference(B).Count;
            long t4 = GetTime();
            string outputTest2 = 
                $"Foreningsmængde: {n1} elementer, {t2 - t1} millisekunder\n" +
                $"Fællesmængde: {n2} elementer, {t3 - t2} millisekunder\n" +
                $"Mængdedifference: {n3} elementer, {t4 - t3} millisekunder\n";
            rw2.MsgTxt.Text = "Set Outputtest2:\n" + outputTest2;
            rw2.Show();
        }

        // Opretter en mængde S med n tilfældige elementer mellem n og 3n.
        // Udfører 20 forespørgsler og printer for hver forespørgsel
        // om elementet findes, og hvor lang forespørgslen tager.
        private static void Test3(int n)
        {
            ISet<int> S = Create(n, n, 3 * n);
            for (int i = 0; i < 20; ++i)
            {
                long t1 = GetTime();
                bool found = S.Contains(rand.Next(n, 3 * n + 1));
                long t2 = GetTime();
                string outputTest3 = $"Found = {found}, {t2 - t1} millisekunder";
                rw3.MsgTxt.Text = "Set outputTest3:\n" + outputTest3;
                rw3.Show();
            }
        }

        // Printer mængde S på skærmen med alle elementer på samme linje adskilt af mellemrum.
        private static void Print(ISet<int> S)
        {
            string outputTest1 = "";
            foreach (int t in S) outputTest1 += $"{t} ";
            rw1.MsgTxt.Text = "Set outputTest1:\n" + outputTest1;
            rw1.Show();
        }

        // Opretter og returnerer en mængde med n elementer af typen int,
        // hvor alle elementer tilhører intervallet [a; b].
        private static ISet<int> Create(int n, int a, int b)
        {
            ISet<int> S = new Set<int>();
            while (S.Count < n) S.Add(rand.Next(a, b + 1));
            return S;
        }

        public static long GetTime()
        {
            DateTime t = DateTime.Now;
            return t.Hour * 3600000L + t.Minute * 60000 + t.Second * 1000 + t.Millisecond;
        }
    }
}
