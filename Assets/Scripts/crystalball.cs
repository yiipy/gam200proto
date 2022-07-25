using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalball : MonoBehaviour
{
    public GameObject crystallballui;
    public GameObject MinimapWindow;
    public GameObject WeatherWindow;
    public GameObject LocationWindow;

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
        if (crystallballui.activeInHierarchy == false)
        {
            crystallballui.SetActive(true);
        }
        else
        {
            crystallballui.SetActive(false);
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