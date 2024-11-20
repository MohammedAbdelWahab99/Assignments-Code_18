using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }
        public void ShowItems()
        {
            foreach (string n in items)
            {
                Debug.Log(n);
            }
        }
        public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory combined = new Inventory();

        foreach (string n in a.items)
        {
            combined.AddItem(n);
        }


        foreach (string n in b.items)
        {
            combined.AddItem(n);
        }

        return combined;
    }
    }
}
