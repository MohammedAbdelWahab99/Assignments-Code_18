using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> itemtest = new GameContainer<string>();
            itemtest.SetItem("Healing Potion");

            string Item_stored = itemtest.GetItem();
            Debug.Log("Stored item: " + Item_stored);

            GameUtils.DescribeItem<string>(Item_stored);
        }
    }
}