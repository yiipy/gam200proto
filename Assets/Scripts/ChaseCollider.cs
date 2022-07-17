using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("InRange", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("InRange", 1);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("InRange", 0);
        }
    }
}