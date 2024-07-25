using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date07_25
{
    public class Delegate
    {


        public static void Main1()
        {
            File file = new File();
            Button button = new Button();
            button.callback = file.Save;
            button.Click();
            button.callback = file.Load;
            button.Click();
            
            Player player = new Player();
            button.callback = player.Jump;
            button.Click();

        }

        public class Player
        {
            public void Jump()
            {
                Console.WriteLine("점프");
            }
        }


        public class Button
        {
            public Action callback;

            public void Click()
            {
                callback();
            }
        }

        public class File
        {
            public void Save()
            {
                Console.WriteLine("저장");
            }
            public void Load()
            {
                Console.WriteLine("불러오기");
            }

        }
        //internal class CallBack
        //{

        //}

        //public class Restaurant
        //{
        //    public Action<Restaurant> OnAcceeptable;

        //    private int curCustomer;
        //    private int maxCustomer;

        //    public bool IsAcceptable()
        //    {
        //        return curCustomer < maxCustomer;
        //    }
        //    public void CheckCustomerCount()
        //    {
        //        if (curCustomer < maxCustomer)
        //        {
        //            OnAcceeptable(this);
        //        }
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
        //        public void Request(Restaurant restaurant)
        //        {
        //            restaurant.OnAcceeptable = TryEnter;
        //        }
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

        //        customer.Request(restaurant);

        //        restaurant.CheckCustomerCount();

        //    }
        //}
    }
}

