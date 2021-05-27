using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class numerovidas : MonoBehaviour
{
    public Text text;
    public int startingLives;
    private int lifeCounter;
 

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        lifeCounter = startingLives + 3;
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = "" + lifeCounter;
        //GetComponent<Text>().text = Platformer.vidas;
    }
    public void TakeLife()
    {
        lifeCounter--;
    }
}
