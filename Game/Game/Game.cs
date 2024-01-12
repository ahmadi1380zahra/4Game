using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class Game
    {
       private static  List<Role> _roles=new();
        public static void AddHero(int herotype,string name,int speed,int power)
        {
            switch (herotype)
            {
                case 1:
                    {
                        var hero = new Hero(name);
                        hero.SetPower(power);
                        hero.Speed = speed;
                        hero.situation = Situation.Alive;
                        _roles.Add(hero);
                        break;
                    }
                case 2:
                    {
                        var enemy = new Enemy(name);
                        enemy.SetPower(power);
                        enemy.situation = Situation.Alive;
                        _roles.Add(enemy);
                        break;
                    }
                case 3:
                    {
                        var nbc = new NBC(name);
                        nbc.SetPower(power);
                        nbc.situation = Situation.Alive;
                        _roles.Add(nbc);
                        break;
                    }
                default:
                    {
                        throw new Exception("we dont have this hero");
                    }
            }
        }

        public static void Attack(string fighterName,string deffenderName)
        {
            var fighter = _roles.Find(item => item.Name == fighterName);
            if (fighter == null)
            {
                throw new Exception("fighter not found");
            }
            if (fighter.situation == Situation.Dead)
            {
                throw new Exception("fighter is dead choose another role");
            }
            var deffender = _roles.Find(item=>item.Name== deffenderName);
            if (deffender == null)
            {
                throw new Exception("deffender not found");
            }
            deffender.Attack(deffender.Health,fighter.Power);
          
        }
    }
}
