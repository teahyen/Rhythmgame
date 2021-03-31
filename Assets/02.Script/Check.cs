using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField]
    private bool IsBit;
    [SerializeField]
    private GameObject Note;
    private void Start()
    {
        IsBit = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsBit = true)
        {

        }
    }
}

