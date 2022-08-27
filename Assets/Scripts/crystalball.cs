using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalball : MonoBehaviour
{
    public GameObject crystallballui;
    public GameObject MinimapWindow;
    public GameObject WeatherWindow;
    public GameObject LocationWindow;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject EnemyUp;
    public GameObject EnemyDown;
    public GameObject EnemyLeft;
    public GameObject EnemyRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (MinimapWindow.activeInHierarchy == true) //if on minimap, go to weather
            {
                MinimapWindow.SetActive(false);
                WeatherWindow.SetActive(true);
                LocationWindow.SetActive(false);
            }

            else if (WeatherWindow.activeInHierarchy == true) //if on weather, go to location
            {
                MinimapWindow.SetActive(false);
                WeatherWindow.SetActive(false);
                LocationWindow.SetActive(true);
            }

            else if (LocationWindow.activeInHierarchy == true) //if on location, go to minimap
            {
                MinimapWindow.SetActive(true);
                WeatherWindow.SetActive(false);
                LocationWindow.SetActive(false);
            }
        }

        if (MinimapWindow.activeInHierarchy == true)
        {
            if (Enemy.transform.position.y > Player.transform.position.y) //if enemy above player
            {
                EnemyUp.SetActive(true);
                EnemyDown.SetActive(false);
            }
            else
            {
                EnemyUp.SetActive(false);
                EnemyDown.SetActive(true);
            }

            if (Enemy.transform.position.x > Player.transform.position.x) //if enemy to the right of player
            {
                EnemyRight.SetActive(true);
                EnemyLeft.SetActive(false);
            }
            else
            {
                EnemyRight.SetActive(false);
                EnemyLeft.SetActive(true);
            }
        }
    }

    public void togglecrystalball()
    {
        if (crystallballui.activeInHierarchy == false)
        {
            //Player.GetComponent<Renderer>().enabled = false;
            crystallballui.SetActive(true);
        }
        else
        {
            crystallballui.SetActive(false);
            //Player.GetComponent<Renderer>().enabled = true;
        }
    }

    public void NextWindow()
    {
        if (MinimapWindow.activeInHierarchy == true) //if on minimap, go to weather
        {
            MinimapWindow.SetActive(false);
            WeatherWindow.SetActive(true);
            LocationWindow.SetActive(false);
        }

        else if (WeatherWindow.activeInHierarchy == true) //if on weather, go to location
        {
            MinimapWindow.SetActive(false);
            WeatherWindow.SetActive(false);
            LocationWindow.SetActive(true);
        }

        else if (LocationWindow.activeInHierarchy == true) //if on location, go to minimap
        {
            MinimapWindow.SetActive(true);
            WeatherWindow.SetActive(false);
            LocationWindow.SetActive(false);
        }
    }

    public void PreviousWindow()
    {
        if (MinimapWindow.activeInHierarchy == true) //if on minimap, go to location
        {
            MinimapWindow.SetActive(false);
            WeatherWindow.SetActive(false);
            LocationWindow.SetActive(true);
        }

        else if (LocationWindow.activeInHierarchy == true) //if on location, go to weather
        {
            MinimapWindow.SetActive(false);
            WeatherWindow.SetActive(true);
            LocationWindow.SetActive(false);
        }

        else if (WeatherWindow.activeInHierarchy == true) //if on weather, go to minimap
        {
            MinimapWindow.SetActive(true);
            WeatherWindow.SetActive(false);
            LocationWindow.SetActive(false);
        }
    }
}