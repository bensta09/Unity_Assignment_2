using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUsername : MonoBehaviour
{
    public Text ShowName;
    public InputField PlayerName;
    public string myPlayerName;


    public void DisplayName()
    {
        myPlayerName = PlayerName.text;
        ShowName.text = myPlayerName;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
