using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Character
    {
        public string Name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100)
                {
                    health = 100;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        public Character(string Name, int health, Position position)
        {
            this.Name = Name;
            Health = health;
            this.position = position;
        }
        public Character() : this("No Name", 100, new Position(0, 0, 0))
        {
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("Name : " + Name + "health : " + Health);
            position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            DRYmethod(damage, target);
        }
        public void Attack(int damage, Character target, string attackType)
        {
            DRYmethod(damage, target);
        }
        public void DRYmethod(int damage, Character target)
        {
            target.Health -= damage;
        }
    }
}

