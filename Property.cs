using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date07_25
{
    internal class Property
    {
        public class Player
        {
            private int hp=100;
            //<속성>
            private int mp;
            
            public int Mp
            {
                get { return mp; }
                set {  mp = value; }
            }
            private float rate;
            private int AP;
            public int TotalDamage => (int)(AP * (1+rate));




            public int GetHP()
            {
                return hp;
            }
            private void SetHP(int hp)
            {
                this.hp = hp;
            }


        }
        public static void Main1()
        {
            Player player = new Player();
            Console.WriteLine($"플레이어의 체력은 {player.GetHP()}");
        }
    }
}
