using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Soldier : Character
    {
        public Soldier(string Name, int health, Position position) : base(Name, health, position) { }
        public Soldier() : base() { }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
