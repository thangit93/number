using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckNumber : MonoBehaviour {
    public Button checkButton;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;
    public Button Button7;
    public Button Button8;
    public Button Button9;

    public int btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;

    // Use this for initialization
    void Start () {
        Button btnChk = checkButton.GetComponent<Button>();
        btnChk.onClick.AddListener(TaskCheck);
    }

    void TaskCheck()
    {
        
        Debug.Log(Button1.GetComponentInChildren<Text>().text);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
