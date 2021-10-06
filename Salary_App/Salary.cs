using System;
using System.Collections;

namespace Salary_App
{
    public class Salary<T> : IEnumerable
    {
        protected int[] salary = new int[] { 200000, 60000, 500000, 400000 };
        public IEnumerator GetEnumerator()
        {
            foreach (var item in salary)
            {
                if (item < 500000)
                {
                    yield return item;
                }
            }
        }
    }
}