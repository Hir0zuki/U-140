using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameover : MonoBehaviour
{
    public GameObject FinishingScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FinishingScreen.SetActive(true);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
