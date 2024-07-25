namespace Date07_25
{// 확장 메서드
    /*
     *클래스를 수정하지 않고도 기능을 추가 할 수 있음
    상속을 통해 만들지 않고도 추가적인 함수를 구현 가능
    정적함수의 첫번째 매개변수를 this, 후 확장하고자 하는 자료형을 작성

    확장 메서드는 최상위 정적 클래스에 정의해야함
    (this 확장하고자 하는 class 매개변수) 
     */

    public class Additional
    {
        static void Main1()
        {
            float value = 2.7f;
            value.Round();

            string text = "Hello World Im Fine Thank You";
            Console.WriteLine(text.WordCount());
            Console.WriteLine(text.CharCount('l'));
        }
    }

    public static class Extenstion
    {
        public static int WordCount(this string text)
        {
            return text.Split(' ').Length;
        }
        public static int CharCount(this string text, char alpa)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == alpa)
                {
                    count++;
                }
            }
            return count;
        }

         



        public static int Round(this float target)
        {
            if (target % 1 >= 0.5f)
            {
                return (int)(target + 1);
            }
            else
            {
                return (int)target;
            }
        }
    }


}

