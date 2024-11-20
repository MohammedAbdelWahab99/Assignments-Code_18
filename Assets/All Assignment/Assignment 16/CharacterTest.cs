using System.Collections;
using System.Collections.Generic;
using Assignment16;
using UnityEngine;
namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Soldier soldier = new Soldier();
            Officer officer = new Officer("zodice", 100, new Position(10, 5, 10));


            Character[] characters = new Character[2];
            characters[0] = soldier;
            characters[1] = officer;

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }
            Debug.Log(soldier.Health);
            officer.Attack(10, soldier, "kicking");
            Debug.Log(soldier.Health);
        }
    }
}
