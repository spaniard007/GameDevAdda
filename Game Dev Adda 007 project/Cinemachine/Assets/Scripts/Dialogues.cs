using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogues : MonoBehaviour
{
    public TextMeshProUGUI textObj;
    public TextMeshProUGUI hint;
    public string[] sentences;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {

        if (sentences.Length.Equals(0))
        {
            textObj.text = sentences[index];
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            nextLine();
        }

        if (textObj.text.Equals("Where is my chicken"))
        {
            hint.text = "press F to find chicken";
            if (Input.GetKeyDown(KeyCode.F))
            {
                Destroy(gameObject);
            }
        }

    }

    public void nextLine()
    {
        if(index < sentences.Length - 1)
        {
            index += 1;
            textObj.text = sentences[index];
        }


    }
    
    public void prevLine()
    {
        if(index > 0)
        {
            index -= 1;
            textObj.text = sentences[index];
        }
    }

}
