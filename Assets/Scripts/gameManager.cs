using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {
    public void OnStartGame(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
