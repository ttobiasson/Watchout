using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour
{
    private void Start(){
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    private void Update(){
        Values.UpdateScore();
    }
    
    public void StartGame(){
        SceneManager.LoadScene("Game");
        Values.ResetScore();

    }
    public void RestartGame(){
        SceneManager.LoadScene("Game");
        Values.ResetScore();

    }


}
