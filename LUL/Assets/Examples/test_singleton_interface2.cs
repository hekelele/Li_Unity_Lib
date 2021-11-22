using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LUL.Pattern;

public class test_singleton_interface2 : MonoBehaviour
{
    private void Start()
    {
        test_singleton_interface.Instance.Test();
    }
}
