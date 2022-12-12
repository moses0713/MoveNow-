using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenutoMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadToLobby()
    {
        SceneManager.LoadScene(1);
    }
    
    
    public void GoToChooseSong()
    {
        SceneManager.LoadScene(2);
    }

    
    public void GoBackToLoby()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToSetting()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToTeach()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToSong1()
    {
        SceneManager.LoadScene(5);
    }
}
