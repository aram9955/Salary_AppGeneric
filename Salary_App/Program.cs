using System;
using System.Collections;
namespace Salary_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary<string> salary = new Salary<string>();
            var result = salary.GetEnumerator();

            for (int i = 0; result.MoveNext(); i++)
            {
                Console.WriteLine(result.Current);
            }
        }
    }
}