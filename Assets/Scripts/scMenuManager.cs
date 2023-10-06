using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scMenuManager : MonoBehaviour
{
    public GameObject menu, inGameUI;
    void DeactiveAll()
    {
        menu.SetActive(false);
        inGameUI.SetActive(false);
    }

    void Update()
    {
        DeactiveAll();
        if (scGameManager.Instance.Status == enGameStatus.MainMenu || scGameManager.Instance.Status == enGameStatus.Paused) menu.SetActive(true); //status MainMenu'de olursa ekran men�y� g�stersin.
        else inGameUI.SetActive(true);

    }
}
