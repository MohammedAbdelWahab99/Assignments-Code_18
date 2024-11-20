using System;
using System.Collections;
using System.Collections.Generic;
using Assignment16;
using UnityEngine;

public class Character
{
    private string character_Name;
    public string _Character_Name
    {
        get { return character_Name; }
        set { character_Name = value; }
    }

    private int character_Health;
    public int _Character_Health
    {
        get { return character_Health; }
        set
        {
            if (value > 100)
            {
                character_Health = 100;
            }
            else if (value < 0)
            {
                character_Health = 0;
            }
            else
            {
                character_Health = value;
            }
        }
    }
    public Character(string name, int health)
    {
        _Character_Name = name;
        _Character_Health = health;
    }
}
