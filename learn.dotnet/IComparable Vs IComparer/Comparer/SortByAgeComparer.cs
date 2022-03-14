using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.dotnet.IComparable_Vs_IComparer.Comparer
{
    public class SortByAgeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
