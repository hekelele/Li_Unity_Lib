using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Author: hekelele / Github
 *  
 *  Unity Singleton Inherit Version
 *  - inherit it and add it to hierachy
 *  
 *  
 *  version: 0.1.1
 *  Last Updated Date: 2021/11/15
 */


namespace LUL.Pattern
{
    public class UnitySingletonNormal<T> : MonoBehaviour where T : Component
    {
        private static T m_Instance;
        
        public static T Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = FindObjectOfType<T>();
                    if (m_Instance == null)
                    {
                        Debug.Log("Instance Not Found, Please Add it in Hierachy First");
                    }
                }

                return m_Instance;
            }
        }
    }

}

