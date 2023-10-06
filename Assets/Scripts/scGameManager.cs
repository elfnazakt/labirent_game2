using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum enGameStatus //Menude görünecekler
{
    MainMenu,
    Playing,
    Paused
}
public class scGameManager : MonoBehaviour
{
    public static scGameManager Instance;
    public enGameStatus Status;

    private void Awake()
    {
        Instance = this;                  //Class'ýn öbjesini temsil eder.
        ShowMenu();                       //Oyun ilk açýldýðýnda görünecek kýsým.
    }

    public void Play()
    {
        Status = enGameStatus.Playing;
        Time.timeScale = 1f;
    }
    public void ShowMenu()
    {
        Status = enGameStatus.MainMenu;
        Time.timeScale = 0f;
    }
    public void Pause()
    {
        if (Status == enGameStatus.Playing)
        {
            Status = enGameStatus.Paused;  //Status Play olursa Pause'a geçicek
            Time.timeScale = 0f;
        }
        else if (Status == enGameStatus.Paused)  //Status Pause olursa Play'e geçicek.
            Play();
    }
}
