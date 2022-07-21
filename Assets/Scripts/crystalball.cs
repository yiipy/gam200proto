using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalball : MonoBehaviour
{
    public GameObject crystallballui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void togglecrystalball()
    {
        Debug.Log("Hello");
        if (crystallballui.activeInHierarchy == false)
        {
            crystallballui.SetActive(true);
        }
        else
        {
            crystallballui.SetActive(false);
        }
    }
}