using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = " Final Score: " + Score.score.ToString();
        
    }


}
