using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date07_25
{
    internal class StringBuilder
    {
        public class TestClass
        {
            public int value;
        }


        public static void Main()
        {
            TestClass left = new TestClass() { value = 10 };
            TestClass right = left;

            left.value = 20;

            Console.WriteLine(left.value);
            Console.WriteLine(right.value);

            string a = "안녕하세요";
            string b = a;

            b = "안녕못해요";

            Console.WriteLine(a);
            Console.WriteLine(b);

            //자주 바뀌는 string은  StringBuilder를 쓰는게 좋음
            StringBuilder sba = new StringBuilder("bcb");
            
            sba.Append("asd");
            sba[0] = 'f';
            sba.Replace('s', 'd');
        }





    }
}
