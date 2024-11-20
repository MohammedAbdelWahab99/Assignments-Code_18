using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Officer : Character
    {
        public Officer(string Name, int health, Position position) : base(Name, health, position) { }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
