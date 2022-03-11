using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.dotnet.Collections.Comparer
{
    public class SortByLastNameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
    }
}
