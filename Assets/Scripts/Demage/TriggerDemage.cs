using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemage : MonoBehaviour
{
    [SerializeField]
    [Min(0)]
    private int demage = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDemageble demageble = collision.GetComponent<IDemageble>();

        if(demageble != null)
        {
            demageble.TakeDemage(demage);
        }
    }
}
