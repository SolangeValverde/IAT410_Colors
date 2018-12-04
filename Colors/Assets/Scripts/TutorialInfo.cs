using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorialInfo : MonoBehaviour
{

    public Text Instruction;

    void Start()
    {
        Instruction = GetComponent<Text>();


        // Instruction.text = "Hello This is Child";
    }
    void Update()
    {
        int i = 0;
        while (i < 2)
        {

            if (Input.GetKeyDown("space"))
            {
                Instruction.text = "Move with the arrow keys Press the S to change your color to green.";
                i++;
            }
            else if (Input.GetKeyDown("space") && (i == 1))
            {
                Instruction.text = "To hide the tutorial help press the ESC button";
                i++;
            }
        }
    }
}




