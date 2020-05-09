using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour
{
    public Text score;
    private float startTime;
    private void Start(){
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        startTime = Time.time;
    }
    private void Update(){
        if(dragPlayer.hasLost){
            score.text = (Time.time - startTime).ToString("F0");
            dragPlayer.hasLost = false;

        }
    }
    
    public void GoToGameScene(){
        SceneManager.LoadScene("Game");
        startTime = Time.time;
    }

}
