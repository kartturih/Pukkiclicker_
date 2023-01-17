using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int multiplier, pukkia;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        pukkia = PlayerPrefs.GetInt("pukkia", 0);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

