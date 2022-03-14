using learn.dotnet.IComparable_Vs_IComparer.Comparable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.dotnet.IComparable_Vs_IComparer
{
    public class EmployeeManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static List<Employee> SortWithoutComparisionInterface(List<Employee> employees)
        {
            employees.Sort();

            return employees;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static List<ComparableEmployee> SortUsingIComparable(List<ComparableEmployee> employees)
        {
            employees.Sort();

            return employees;
        }

        public static List<Employee> SortWithIComparerInterface(List<Employee> employees, IComparer<Employee> comparer)
        {
            employees.Sort(comparer);

            return employees;
        }
    }
}
