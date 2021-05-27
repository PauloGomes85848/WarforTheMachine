using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class numeroPecas : MonoBehaviour
{
    public Text text;
    public int startingPecas;
    private int pecasCounter;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        pecasCounter = startingPecas;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + pecasCounter;
        //GetComponent<Text>().text = Platformer.vidas;
    }

    public void addPeca()
    {
       pecasCounter++;
      
    }
}
