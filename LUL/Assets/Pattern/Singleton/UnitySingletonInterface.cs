using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Author: hekelele / Github
 *  
 *  Unity Singleton Interface Version
 *  - inherit it and add it to hierachy
 *  
 *  
 *  version: 0.1.0
 *  Last Updated Date: 2021/11/22
 */

namespace LUL.Pattern
{
    public interface IUnitySingleton<T> where T : Component
    {
    }

    // ExISingleton == Unity Single Interface Extended 
    public class ExIUnitySingleton<T> : MonoBehaviour where T : Component
    {
        public static T GetInstance()
        {
            if (SingletonCreator.instance == null)
            {
                Debug.Log("Instance Not Found, Please Add it in Hierachy First");
            }

            return SingletonCreator.instance;
        }

        class SingletonCreator
        {
            static SingletonCreator() { }
            internal static readonly T instance = FindObjectOfType<T>();
        }
    }
}
