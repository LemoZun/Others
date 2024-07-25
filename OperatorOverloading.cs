namespace Date07_25
{
    internal class OperatorOverloading
    {
        /*
         * 연산자 재정의
         * 사용자 정의 자료형이나 클래스의 연산자를 재정의하
         */

        public struct Point
        {

            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Point operator +(Point a, Point b) // 연산자 재정의
            {
                return new Point(a.x + b.x, a.y + b.y);
            }

            public static Point operator -(Point a, Point b) // 연산자 재정의
            {
                return new Point(a.x - b.x, a.y - b.y);
            }


        }

        public static void Main0()
        {
            Point point1 = new Point();
            Point point2 = new Point();

            Point sum = point1 + point2;
            // (1,2) + (2,3) == (3,5)
        }


        // <Named Parameter>
        // 함수의 매개변수 순서와 무관하게 이름을 통해 호출
        void Profile(int id, string name, string phone) { }

        void Main1()
        {
            // 함수 호출시 이름을 명명하고 순서와 상관없이 호출 가능
            Profile(phone: "010-1111-2222", id: 1, name: "홍길동");
            Profile(name: "홍길서", phone: "010-1234-5678", id: 2);
        }


        // <Optional Parameter>
        // 함수의 매개변수가 초기값을 갖고 있다면, 함수 호출시 생략하는 것을 허용하는 방법
        void AddStudent(string name, string home = "서울", int age = 8) { }   // 초기값이 있는 경우 미리 할당
        // void AddStudent(int age = 8, string home = "서울", string name) {} // error : 초기값이 있는 매개변수는 뒤부터 배치해야함

        void Main2()
        {
            AddStudent("철수");               // AddStudent("철수", "서울", 8);
            AddStudent("영희");               // AddStudent("영희", "서울", 8);
            AddStudent("민준", "인천");       // AddStudent("민준", "인천", 8);
            AddStudent("미영", age: 7);       // AddStudent("미영", "서울", 7);
        }

        // <Params Parameter>
        // 매개변수의 객수가 정해지지 않은 경우, 매개변수의 갯수를 유동적으로 사용하는 방법
        int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++) sum += values[i];
            return sum;
        }

        void Main3()
        {
            Sum(1, 3, 5, 7, 9);
            Sum(3, 5, 7);
            Sum();
        }

    }

}
