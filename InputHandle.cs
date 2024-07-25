namespace Date07_25
{
    internal class InputHandle
    {
        public static void Main1()
        {

        }
        public class InputDevice
        {
            public Action akey;
            public Action sKey;

            public void Input(char key)
            {
                switch (key)
                {
                    case 'a':
                        akey();
                        break;
                    case 's':
                        sKey();
                        break;


                }

            }
        }

        public class Player
        {
            public void Jump()
            {
                Console.WriteLine("플레이어 점프");
            }
            public void Skill()
            {
                Console.WriteLine("플레이어 스킬");
            }


        }




    }
}
