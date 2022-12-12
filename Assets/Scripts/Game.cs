using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public void OnStartGame(string ScneneName){
        Application.LoadLevel(ScneneName);
    }
}
