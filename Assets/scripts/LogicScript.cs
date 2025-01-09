using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
public int playerScore;
public Text scoreText;
public Text scoreText2;

//public Text scoreTextPanner;
public int pipeCount;
public Text countText;
public Text countText2;


public AudioSource Loosing;
public AudioSource hit;
public AudioSource victory;
public GameObject gameOverScreen;
public GameObject WinScreen;




[ContextMenu("Increase Score")]
public void addScore(int scoreToAdd)
{
playerScore=playerScore+scoreToAdd;
scoreText.text = playerScore.ToString();
scoreText2.text = playerScore.ToString();

}


[ContextMenu("Increase Score")]
public void PipesCounter(int scoreToAdd)
{
pipeCount=pipeCount+scoreToAdd;
countText.text = pipeCount.ToString();
countText2.text = pipeCount.ToString();


}


 public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


 
    public void gameOver()
    {
       hit.Play();
       Loosing.Play();
       gameOverScreen.SetActive(true);
       
    }

   public void Winner()
    {
       victory.Play();
       WinScreen.SetActive(true);       
    }

public void ChangeScene(){
    SceneManager.LoadScene(1);
}


}
