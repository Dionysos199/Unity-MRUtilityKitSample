using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressNumber : MonoBehaviour
{
    [SerializeField] string number;
    public void onNumberPressed()
    {
        GetComponentInParent<PinNumber>().OnDigitPressed(number);
    }
}
