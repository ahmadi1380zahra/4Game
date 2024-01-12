using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Role
    {
        protected Role(string name)
        {
            Name = name;
            Health = 100;
        }
        public string Name { get; set; }
        public int Health { get; set; }

        public int Power { get;private set; }
        public Situation situation { get; set; }

        public void SetPower(int power)
        {
            if (power > 90)
            {
                throw new Exception("power cant be more then 90");
            }
            Power = power;
        }
        public void Attack(int health, int enemyPower)
        {
            if (health <= 0)
            {

                situation = Situation.Dead;
                throw new Exception("this role is already dead");
            }
            if (situation == Situation.Alive)
            {
                Health = health - enemyPower;
                if (Health <= 0)
                {

                    situation = Situation.Dead;
                    throw new Exception("You killed your enemy ");
                }
            }
        }

    }

    class Hero : Role
    {
        public Hero(string name) : base(name)
        {

        }
        public int Speed { get; set; }
    }
    class Enemy : Role
    {
        public Enemy(string name) : base(name)
        {

        }
    }
    class NBC : Role
    {
        public NBC(string name) : base(name)
        {

        }
    }
    enum Situation
    {
        Dead,
        Alive
    }
}
