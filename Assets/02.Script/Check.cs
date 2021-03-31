using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField]
    private bool IsBit;
    [SerializeField]
    private int Money;
    [SerializeField]
    private GameObject Note;

    private bool isClick = false;

    public void OnClick()
    {
        if (isClick == true)
            Money += 1000;
        else
            Money -= 100;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Bit"))
        {
            isClick = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Bit"))
        {
            isClick = false;
        }
    }
}

