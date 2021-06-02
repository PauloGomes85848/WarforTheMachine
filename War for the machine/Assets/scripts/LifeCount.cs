using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    private Image[] lives = new Image[3];
    private int livesRemaining = 3;
    private Image life1;
    private Image life2;
    private Image life3;
    

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

    private void Start() {
        life1 = GameObject.Find("Life").GetComponent<Image>();
        life2 = GameObject.Find("Life2").GetComponent<Image>();
        life3 = GameObject.Find("Life").GetComponent<Image>();
        lives[0] = life3;
        lives[1] = life2;
        lives[2] = life1;
    }

    private void Update() 
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
        }
    }
}
