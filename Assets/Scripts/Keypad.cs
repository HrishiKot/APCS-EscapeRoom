using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Keypad : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject clearButton;
    public GameObject enterButton;

    public void b1(){
        charHolder.text = charHolder.text + "1";
    }

    public void b2(){
        charHolder.text = charHolder.text + "2";
    }

    public void b3(){
        charHolder.text = charHolder.text + "3";
    }

    public void b4(){
        charHolder.text = charHolder.text + "4";
    }

    public void b5(){
        charHolder.text = charHolder.text + "5";
    }

    public void b6(){
        charHolder.text = charHolder.text + "6";
    }

    public void b7(){
        charHolder.text = charHolder.text + "7";
    }

    public void b8(){
        charHolder.text = charHolder.text + "8";
    }

    public void b9(){
        charHolder.text = charHolder.text + "9";
    }

    public void b0(){
        charHolder.text = charHolder.text + "0";
    }

    public void clearEvent(){
        charHolder.text = null;
    }

    public void enterEvent(){
        if(charHolder.text == "1423"){
            charHolder.text = "Success";
            SceneManager.LoadScene("Transition");
        } else {
            charHolder.text = "Invalid";
        }
    }
}