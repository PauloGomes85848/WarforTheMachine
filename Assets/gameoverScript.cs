using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameoverScript : MonoBehaviour
{
    public Text textinput;
    // Start is called before the first frame update
    private string GameOver;
    void Start()
    {
        textinput = GetComponent<Text>();
        GameOver = "";
    }

    // Update is called once per frame
    void Update()
    {
        textinput.text = GameOver;
    }
    public void sayGameOver()
    {
        GameOver = "GAME OVER!";
    }
}