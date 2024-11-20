using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerrr : Character
{
    public Playerrr(string name, int health) : base(name, health) { }
    public void Heal(int amount)
    {
        _Character_Health += amount;
    }
}
