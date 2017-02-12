using UnityEngine;
using System.Collections;

public class Level_Loader : MonoBehaviour {

    public string startGame;

    public void restartLevel()
    {
        Application.LoadLevel(startGame);
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
	        
	}
}
