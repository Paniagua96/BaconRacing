﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Real_Menu_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Main_Menu_Canvas;
    public GameObject Character_Screen;
    public GameObject Tracks_Screen;
    public void To_Title_Screen(){
        Main_Menu_Canvas.SetActive(true);
        Character_Screen.SetActive(false);
        Tracks_Screen.SetActive(false);
    }

    public void To_Characters_Screen(){
         Main_Menu_Canvas.SetActive(false);
        Character_Screen.SetActive(true);
        Tracks_Screen.SetActive(false);
    }

     public void To_Tracks_Screen(){
        Main_Menu_Canvas.SetActive(false);
        Character_Screen.SetActive(false);
        Tracks_Screen.SetActive(true);
    }
}
