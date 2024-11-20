using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
        Inventory potions = new Inventory();
        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");

        Inventory elixir = new Inventory();
        elixir.AddItem("Elixir");
        elixir.AddItem("Dark Elixir");

        Inventory combined_Inven = potions + elixir;

        combined_Inven.ShowItems();
        }
    }
}
