using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destination : MonoBehaviour
{
    [SerializeField]
    private Text dropdownText;
    public SpriteRenderer passenger;



    private bool dropDownAllowed;
    // Start is called before the first frame update
    private void Start()
    {
        dropdownText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dropDownAllowed && Input.GetKeyUp(KeyCode.E))
            DropDown();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            dropdownText.gameObject.SetActive(true);
            dropDownAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            dropdownText.gameObject.SetActive(false);
            dropDownAllowed = false;
        }
    }

    private void DropDown()
    {

        passenger.gameObject.SetActive(true);
    }
}
