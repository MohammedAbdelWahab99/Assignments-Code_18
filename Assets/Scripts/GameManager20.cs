using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager20 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Playerrr player = new Playerrr("zain", 70);
        Enemy enemy = new Enemy("Mohammed", 100);

        Debug.Log("The Player Name & Health : " + player._Character_Name + " " + player._Character_Health);
        Debug.Log("The Enemy Name & Health : " + enemy._Character_Name + " " + enemy._Character_Health);

        player.Heal(50);
        Debug.Log("The Health Been Increasesing, So The Health Of The Player Is :  " + player._Character_Health);

        enemy.Attack(player, 10);
        Debug.Log("The Enemy Attacked Player So The Health Of The Player Is : " + player._Character_Health);
    }
}
