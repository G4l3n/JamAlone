using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPnj : MonoBehaviour
{

    public CastCheckPnj checkPnj;
    public PlayerMovement playerMovement;
    public GameObject interactText;
    public GameObject ObjectPnjText;
    public TMPro.TextMeshProUGUI PnjTextFromBack;
    public TMPro.TextMeshProUGUI dialogueTMPro;
    public bool isPnjTrigger;
    public TextDictionary textDictionary;
    public string keyDialogues;
    public bool interactPressed;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pnj"))
        {
            isPnjTrigger = true;
        }
    }


    private void Update()
    {
        if (checkPnj.isPnj && isPnjTrigger)
        {
            interactText.SetActive(true);
            if (Input.GetKeyDown("e"))
            {
                interactPressed = true;
                ObjectPnjText.SetActive(true);
                interactText.SetActive(false);
                dialogueTMPro.SetText(textDictionary.DialoguesDataBase[keyDialogues]);
            }
        }
        else
        {
            interactText.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pnj"))
        {
            interactPressed = false;
            isPnjTrigger = false;
            interactText.SetActive(false);
            ObjectPnjText.SetActive(false);
        }
        
    }
}
