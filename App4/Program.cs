using System;
using System.Collections.Generic;
using System.Linq;

namespace App4
{
    class Program
    {
        /// <summary>
        /// Возвращает отсортированный по возрастанию поток чисел
        /// </summary>
        /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
        /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
        /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
        /// <returns>Отсортированный по возрастанию поток чисел.</returns>
        public static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            int[] counter = new int[maxValue + 1];
            int k = 0;
            foreach (var x in inputStream)
            {
                counter[x]++;
                int newX = x - sortFactor;
                if (k < newX)
                {
                    while(counter[k] != 0)
                    {
                        yield return k;
                        counter[k]-- ;
                    }
                    k++;
                }
            }
            while (k < counter.Length)
            {
                while (counter[k] != 0)
                { 
                    yield return k;
                    counter[k]--;
                }
                k++;
            }
        }

        static void Main(string[] args)
        {
            IEnumerable<int> test = new List<int>() { 7, 8, 4, 5, 7, 8, 4, 5, 4, 9, 5, 8 , 5 , 6 , 7 , 8 , 9 , 8 ,9 , 7 ,8 ,7 ,5 ,4 ,5 ,6 ,4, 4,6, 8,4 ,5 ,6 ,4,5,6, 10,11,21,33,35,36};
            IEnumerable<int> result = Sort(test, 5, 36);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
