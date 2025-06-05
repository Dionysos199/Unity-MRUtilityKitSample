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
            Debug.Log("Correct PIN!");
            UnlockBriefcase(); // your method here
        }
        else
        {
            Debug.Log("Incorrect PIN!");
            //ResetInput(); // optional
        }
    }

    [SerializeField] private HingeJoint hinge1;
    public void UnlockBriefcase()
    {


        // Get current limits
        JointLimits limits = hinge1.limits;

        // Modify the max limit
        limits.min = -120f; // for example, 90 degrees
        // Optionally modify min too
        // limits.min = -45f;

        // Apply modified limits back
        hinge1.limits = limits;
    }
    public void lockBrief()
    {


        // Get current limits
        JointLimits limits = hinge1.limits;

        // Modify the max limit
        limits.max = 90f; // for example, 90 degrees

        // Optionally modify min too
        // limits.min = -45f;

        // Apply modified limits back
        hinge1.limits = limits;
    }
}
