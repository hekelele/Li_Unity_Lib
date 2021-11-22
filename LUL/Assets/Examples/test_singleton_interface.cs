using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LUL.Pattern;

public class test_singleton_interface : MonoBehaviour,
    IUnitySingleton<test_singleton_interface>
{
    public static test_singleton_interface Instance
    {
        get
        {
            return ExIUnitySingleton<test_singleton_interface>.GetInstance();
        }
    }

    public void Test()
    {
        Debug.Log("Hello2");
    }
    

}
