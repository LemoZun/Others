using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date07_25
{
    internal class Specifier //지정자
    {
        public static void Main1()
        {
            // bool bigger = Compare(3, 2, Bigger);
            // bool less = Compare(3, 5, Less);

            int[] array = { 1, 3, 5, 7, 9 };
            int less = CountIf(array, 4, Less); //배열 안에서 4보다 작은거 몇개니
            int bigger = CountIf(array, 4, Bigger); //배열 안에서 4보다 큰거 몇개니
            //기준을 넣어서 기준대로 돌아가는 함수를 만들 수 있음
            Console.WriteLine(less);
        }

        public static bool Bigger(int left, int right)
        {
            return left> right;
        }
        public static bool Less(int left, int right)
        {
            return left <  right;
        }

        public static int CountIf(int[] array, int value, Func<int, int, bool> comparer)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (comparer(element, value))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool Compare(int left, int right, Func<int, int, bool> comparer)
        {
            return comparer(left, right);
        }






    }
    
}
