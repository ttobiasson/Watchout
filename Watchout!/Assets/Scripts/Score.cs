using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    void Update(){
        if(dragPlayer.hasLost){
            score.text = Values.GetScore();
            Values.ResetScore();
            dragPlayer.hasLost = false;
        }
        
    }
    
}