using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date07_25
{
    public class Event
    {

        public static void Main1()
        {
            Player player = new Player();
            UI ui = new UI();
            Sound sound = new Sound();
            Monster monster1 = new Monster();
            Monster monster2 = new Monster();
            Camera cam = new Camera();

           // player.OnDied = ui.GameOverUI;
            player.OnDied += sound.DeadSound;
            player.OnDied += monster1.StopAttack;
            player.OnDied += monster2.StopAttack;

            player.Die();

            Console.WriteLine("음소거했습니다.");
            player.OnDied -= sound.DeadSound;

           // player.OnDied = cam.Shake; // 대입을 해버리면 이전게 다 사라짐

            player.Die();


            ////델리게이트 체인
            //Action action;
            //action = AAA;
            //action();

            //action += BBB;
            //action();

            //action += CCC;
            //action();

            //action -= AAA;
            //action -= AAA; // 없는거 빼려고하면 무시
            //action();


        }
        //public static void AAA()
        //{
        //    Console.WriteLine("AAA");
        //}
        //public static void BBB()
        //{
        //    Console.WriteLine("BBB");
        //}
        //public static void CCC()
        //{
        //    Console.WriteLine("CCC");
        //}

        public class Camera
        {
            public void Shake()
            {
                Console.WriteLine("카메라가 흔들림");
            }
        }





        public class Player
        {
            public event Action OnDamaged;

            public event Action OnDied; // 이벤트

            public void TakeDamage()
            {
                Console.WriteLine("데미지 받음");
                if(OnDamaged != null)
                    OnDamaged();

            }


            public void Die()
            {
                Console.WriteLine("플레이어 죽음");
                if (OnDied != null)
                {
                    OnDied(); // 사건이 발생했을때 이벤트 발생
                }
                //서글픈음악
                //게임오버 ui
                //몬스터는 플레이어 공격을 멈춤
                // 여러 객체가 반응하게 해야함
                //객체가 추가된다면 매번 여기서 추가해야함
                // 기능이 추가될수록 Player쪽에 구현하기 힘듬
                // 죽었다는거만 알려주고 각자의 객체에서 실행하게 만들면 편할것


            }
        }

        public class UI
        {
            public void GameOverUI()
            {
                Console.WriteLine("게임오버 UI 창");
            }
        }
        public class Sound
        {
            public void DeadSound()
            {
                Console.WriteLine("서글픈 음악 출력");
            }
        }
        public class Monster
        {
            public void StopAttack()
            {
                Console.WriteLine("몬스터가 공격을 멈춥니다.");
            }
        }
    }
}
