using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scWinningScreen : MonoBehaviour
{
    public static scGameManager Instance;
    public enGameStatus Status;
    public GameObject playerObj, WinMenu;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (WinMenu.active == false)
            {
                WinMenu.SetActive(true);
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
