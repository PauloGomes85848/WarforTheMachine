using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;
    

    public void LoseLife()
    {
        //Se não tiver vidas não faz nada
        if (livesRemaining == 0)
        {
            return;   
        }
        //Diminui o valor de livesRemaining
        livesRemaining--;
        //Esconde uma das imagens do coração
        lives[livesRemaining].enabled = false;
        //if we run out of lives we lose the game
        if(livesRemaining == 0)
        {
            Debug.Log("You lost");
        }
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
        }
    }
}
