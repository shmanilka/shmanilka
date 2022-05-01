using System;
using RougeLikeGame;

namespace Game
{
    class Programm
    {
        public static void Main()
        {
            List<List<GameObject>> Map = Floor.Builder();
            int HeroDamage = 5;
            int HeroHealth = 100;
            int MonsterDamage = 2;
            int MonsterHealth = 20;
            GameObject Exit = new GameObject(0, 0, '<');
            Character Monster = new Character(0, 0, 'M', MonsterDamage, MonsterHealth, 0, 0, 0, false);
            Character hero = new Character(0, 0, '@', HeroDamage, HeroHealth, 0 , 0, 1,true);
            hero = Character.CoordinateRandomizer(Map, hero);
            Monster = Character.CoordinateRandomizer(Map, Monster);
            Exit = GameObject.CoordinateRandomizer(Map, Exit);
            Map = GameObject.Seter(Map, hero);
            Map = GameObject.Seter(Map, Monster);
            Map = GameObject.Seter(Map, Exit);
            while (HeroHealth != 0){
                Floor.Сartographer(Map);
                Monster = Character.MonsterControl(Map, hero, Monster);
                Map = Character.Mover(Map, Monster);
                hero = Character.HeroControl(Map, hero);
                Map = Character.Mover(Map, hero);                                                         
                Console.Clear();
            }
        }
    }
}