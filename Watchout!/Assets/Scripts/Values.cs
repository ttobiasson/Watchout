using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class Values
{
    public static int recentScore = 0;

    public static string GetScore(){
        return recentScore.ToString();
    }
    public static void UpdateScore(){
        recentScore++;
    }
    public static void ResetScore(){
        recentScore = 0;
    }
}