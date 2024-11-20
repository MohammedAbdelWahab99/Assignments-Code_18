using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }
    public void Attack(Character target, int damage)
    {
        target._Character_Health -= damage;
    }
}
