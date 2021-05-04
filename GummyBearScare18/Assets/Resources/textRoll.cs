using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textRoll : MonoBehaviour
{

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = "Roll Dice!";
    }

    // Update is called once per frame
    void Update()
    {
        if(one.GetComponent<DiceSideFound>().isFound)
        {
            this.GetComponent<Text>().text = "You rolled a ONE!";
        }

        if (two.GetComponent<DiceSideFound>().isFound)
        {
            this.GetComponent<Text>().text = "You rolled a TWO!";
        }

        if (three.GetComponent<DiceSideFound>().isFound)
        {
            this.GetComponent<Text>().text = "You rolled a THREE!";
        }

        if (four.GetComponent<DiceSideFound>().isFound)
        {
            this.GetComponent<Text>().text = "You rolled a FOUR!";
        }

        if (five.GetComponent<DiceSideFound>().isFound)
        {
            this.GetComponent<Text>().text = "You rolled a FIVE!";
        }

        if (six.GetComponent<DiceSideFound>().isFound)
        {
            this.GetComponent<Text>().text = "You rolled a SIX!";
        }
    }
}
