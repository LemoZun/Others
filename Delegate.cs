namespace Date07_25
{
    internal class Delegatea
    {
        public delegate float MyDel(float left, float right);
        public delegate void StrDel(string str);

        public static float Plus(float left, float right) { return (left + right); }
        public static float Minus(float left, float right) { return (left - right); }

        public static void Message(string text) { Console.WriteLine(text); }
        static void Main1(string[] args)
        {


            int value = 1;
            double db = 2.2;
            MyDel delegate1 = Plus;

            Console.WriteLine($"10 + 20 = {Plus(10, 20)}");
            Console.WriteLine($"10 + 20 = {delegate1(10, 20)}"); // 둘이 같은 내용

            delegate1 = Minus;
            Console.WriteLine($"10 + 20 = {Minus(10, 20)}");
            Console.WriteLine($"10 + 20 = {delegate1(10, 20)}");

            Message("안녕");
            StrDel delegate2 = Message;
            delegate2("안녕");



            //delegate1 = Message; // delegate1은 MyDel로 정의되었는데 이 델리게이트는 float 변수 두개를 받고 float를 반환해야 한다
            //delegate1("안녕하세요");

            //Func<float, float, float> func;
            //Action<string> action;
        }

        public abstract class Animal
        {
            public abstract void Cry();
        }
        public class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("야옹");
            }
        }

        public static void GenericDel()
        {
            Func<float, double, int> func1 = Function;
            Action<int, float> action1 = Action1;

            //Animal cat = new Cat();
            //Action cryDel = cat.Cry();

        }
        public static int Function(float a, double b) { return 0; }
        public static void Action1(int a, float b) { }

    }
}




//public class Restaurant
//{
//    private int curCustomer;
//    private int maxCustomer;

//    public bool IsAcceptable()
//    {
//        return curCustomer < maxCustomer;
//    }
//    public void Enter()
//    {
//        if (IsAcceptable())
//        {
//            Console.WriteLine("입장");
//        }
//        else
//        {
//            Console.WriteLine("가득찼으니 기다려");
//        }

//    }
//    public class Customer
//    {
//        public void TryEnter(Restaurant restaurant)
//        {
//            restaurant.Enter();
//        }
//    }
//    static void Main(string[] args)
//    {
//        Customer customer = new Customer();
//        Restaurant restaurant = new Restaurant();

//        customer.TryEnter(restaurant);
//        customer.TryEnter(restaurant);
//        customer.TryEnter(restaurant);
//        customer.TryEnter(restaurant);  // 손님입장에서 들어갈래만 시도하면 너무 오래걸릴 수 있음

//        Console.WriteLine("Hello, World!");
//    }
//}

