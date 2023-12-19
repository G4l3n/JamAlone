using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backTalking : MonoBehaviour
{
    public Pnj pnj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pnj.playerInBack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pnj.playerInBack = false;
        }
    }

}
