using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.pukkia += GameManager.multiplier;
        PlayerPrefs.SetInt("pukkia", GameManager.pukkia);
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.pukkia >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.pukkia -= 25;
            PlayerPrefs.SetInt("pukkia", GameManager.pukkia);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.pukkia >= 250)
        {
            GameManager.multiplier += 10;
            GameManager.pukkia -= 250;
            PlayerPrefs.SetInt("pukkia", GameManager.pukkia);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.pukkia >= 2500)
        {
            GameManager.multiplier += 100;
            GameManager.pukkia -= 2500;
            PlayerPrefs.SetInt("pukkia", GameManager.pukkia);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    void Update()
    {
        ui.text = "Pukkia: " + GameManager.pukkia;
    }
}
