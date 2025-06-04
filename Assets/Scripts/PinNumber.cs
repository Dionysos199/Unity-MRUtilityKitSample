using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinNumber : MonoBehaviour
{
    private string currentInput = "";
    public string secretPin = "1984"; // set in Inspector

    public void OnDigitPressed(string digit)
    {
        if (currentInput.Length >= 4)
            return;

        currentInput += digit;

        if (currentInput.Length == 4)
            CheckPin();
    }
    private void CheckPin()
    {
        if (currentInput == secretPin)
        {
            Debug.Log("✅ Correct PIN!");
            //UnlockBriefcase(); // your method here
        }
        else
        {
            Debug.Log("❌ Incorrect PIN!");
            //ResetInput(); // optional
        }
    }

}
