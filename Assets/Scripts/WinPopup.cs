using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopup : MonoBehaviour
{
    public GameObject winPopup;
    // Start is called before the first frame update
    void Start()
    {
        winPopup.SetActive(false);
    }


    public void OnEnable()
    {
        GameEvents.OnBoardCompleted += ShowWinPopup;
    }

    public void OnDisable()
    {
        GameEvents.OnBoardCompleted -= ShowWinPopup;
    }

    private void ShowWinPopup()
    {
        winPopup.SetActive(true);
    }

    public void LoadNextLevel()
    {
        GameEvents.LoadNextLevelMethod();
    }

}
