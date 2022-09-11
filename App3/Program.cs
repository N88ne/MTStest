using System;
using System.Collections.Generic;
using System.Linq;

namespace App3
{   
    
    static class Program
    {
        /// <summary>
        /// <para> Отсчитать несколько элементов с конца </para>
        /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
        /// </summary> 
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
        /// <returns></returns>
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
        {
            IList<(T item, int? tail)> items = new List<(T item, int? tail)>();
            int l = enumerable.Count();
            if(tailLength <= 0)
            {
                foreach (var item in enumerable)
                {
                    items.Add((item,null));
                }
                return items;
            }
            if (l <= tailLength)
            {
                foreach (var item in enumerable)
                {
                    items.Add((item, --l));
                }
                return items;
            }
            else
            {
                int k = 1;
                foreach (var item in enumerable)
                {
                    if (l - k == tailLength - 1)
                    {
                        items.Add((item, --tailLength));
                        k++;
                    }
                    else
                    {
                        items.Add((item, null));
                        k++;
                    }
                }
                return items;
            }
        }
        static void Main(string[] args)
        {

            IEnumerable<(int item, int? tail)> numbers = new[] { 1, 2, 3, 4}.EnumerateFromTail(4);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
