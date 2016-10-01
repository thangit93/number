using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeNumber : MonoBehaviour {
    public Button numberButton;
    public int buttonVal;
    public int maxVal;
    // Use this for initialization
    void Start () {
        buttonVal = 0;
        Button btnNum = numberButton.GetComponent<Button>();
        btnNum.onClick.AddListener(TaskOnClick);
        numberButton.GetComponentInChildren<Text>().text = "";
    }

    void TaskOnClick()
    {
        if(buttonVal < maxVal)
        {
            buttonVal = buttonVal + 1;
        }
        else
        {
            buttonVal = 1;
        }
        
        //Debug.Log("You have clicked the button!");
        numberButton.GetComponentInChildren<Text>().text = buttonVal.ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
