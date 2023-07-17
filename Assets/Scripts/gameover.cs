using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject GameOverScreen;

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }


}
