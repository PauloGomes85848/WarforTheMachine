using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class numeroPontos : MonoBehaviour
{
    public Text text;
    public int startingPoints;
    private int pointsCounter;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        pointsCounter = startingPoints;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + pointsCounter;
        //GetComponent<Text>().text = Platformer.vidas;
    }

    public void AddPoint()
    {
        pointsCounter++;
    }
}
