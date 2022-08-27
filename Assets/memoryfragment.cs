using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryfragment : MonoBehaviour
{
    public GameObject memoryfragmentui;

    public void togglememoryfragment()
    {
        if (memoryfragmentui.activeInHierarchy == false)
        {
            memoryfragmentui.SetActive(true);
        }
        else
        {
            memoryfragmentui.SetActive(false);
        }
    }
}
