using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimpleLock : MonoBehaviour
{
    public bool Interactable = true;
    public GameObject LockCanvas;
    public TMP_Text[] Text;

    public string Password;
    public string[] LockCharacterChoices;
    public int[] _LockCharacterNumber;
    public string _insertedPassword;
    // Start is called before the first frame update
    void Start()
    {
        _LockCharacterNumber = new int[Password.Length];
    }

    public void ChangeInsertedPassword(int number){
        _LockCharacterNumber[number]++;
        if(_LockCharacterNumber[number] >= LockCharacterChoices[number].Length){
            _LockCharacterNumber[number] = 0;
        }
        CheckPassword();
        UpdateUI();
    }

    public void CheckPassword(){
        int pass_len = Password.Length;
        _insertedPassword = "";
        for(int i = 0; i < pass_len; i++){
            _insertedPassword += LockCharacterChoices[i][_LockCharacterNumber[i]].ToString();
        }
        if(Password == _insertedPassword){
            Unlock();
        }
    }

    public void Unlock(){
        Debug.Log("Unlocked");
    }

    public void UpdateUI(){
        int len = Text.Length;
        for(int i = 0; i < len; i++){
            Text[i].text = LockCharacterChoices[i][_LockCharacterNumber[i]].ToString();
        }
    }

    private void OnMouseDown(){
        if(Interactable){
            Interact();
        }
    }

    public void Interact(){
        LockCanvas.SetActive(true);
    }

    public void stopInteract(){
        LockCanvas.SetActive(false);
    }
}
