using System;

namespace Richtersubstitution
{
    #region 里氏替换原则

    //父类容器装载子类对象,但是不能用子类装父类

    #endregion
    public class GameObject
    {
        
    }

    public class Monster : GameObject
    {
        public void MonsterAttack()
        {
            Console.WriteLine("Monster is attacking");
        }
    }

    public class Player : GameObject
    {
        public void PlayerAttack()
        {
            Console.WriteLine("Player is attacking");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameObject gameObject = new GameObject();
            GameObject monster = new Monster();
            GameObject player = new Player();
            GameObject[] ArrayGameObjects = new GameObject[] { monster, player };

            #region is和as

            //is判断对象是否是指定对象，返回bool值
            //as将一个对象转为指定类型，返回对象值或者NULL
            if (player is Player)
            {
                Player substitutionToPlayer = player as Player;
                substitutionToPlayer.PlayerAttack();
                //或者
                (player as Player).PlayerAttack();
            }

            for (int i = 0; i < ArrayGameObjects.Length; i++)
            {
                if (ArrayGameObjects[i] is Player)
                {
                 (ArrayGameObjects[i] as Player).PlayerAttack();   
                }
                else if (ArrayGameObjects[i] is Monster)
                {
                    (ArrayGameObjects[i] as Monster).MonsterAttack();
                }
                
            }
            #endregion
        }
    }
}