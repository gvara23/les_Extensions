namespace les_Extensions
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an entier n please :");
            int n =Convert.ToInt32(Console.ReadLine());

            int[] table= {1,2,3,4,5,6,7,8,9}; 

            double average= table.Where(x => x <= n).Aggregate(0.0, (acc,val) => acc + val)/ table.Count(x => x <= n);
            Console.WriteLine("Table of entiers : " + string.Join(",", table));
            Console.WriteLine("Average of the elements lower or equal to " + n + ":" + average);
        }
    }
}
