using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GameUtils
    {
        public static T DescribeItem<T>(T something)
        {

            Debug.Log("This item is " + something);
            return something;
        }
    }
}
