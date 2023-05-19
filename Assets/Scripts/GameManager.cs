using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Padlle;
    public GameObject player1Goal;
        
    [Header("Player 2")]
    public GameObject player2Padlle;
    public GameObject player2Goal;

    [Header("Score uI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored(){
        Player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
     public void Player2Scored(){
        Player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Padlle.GetComponent<Paddle>().Reset();
        player2Padlle.GetComponent<Paddle>().Reset();
    }
    
}
