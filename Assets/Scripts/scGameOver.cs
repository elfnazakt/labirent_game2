using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scGameOver : MonoBehaviour
{
    public static scGameManager Instance;
    public enGameStatus Status;
    public GameObject playerObj, GameOverMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Çarpýþtý.");
            if (GameOverMenu.active == false)
            {
                GameOverMenu.SetActive(true);
                Status = enGameStatus.Playing;
                Time.timeScale = 0f;
                scGameManager.Instance.Status = enGameStatus.Paused;
            } 
        }
    }
    public void Reset()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
