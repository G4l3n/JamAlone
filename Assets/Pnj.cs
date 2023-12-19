using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pnj : MonoBehaviour
{

    [Header("GameObjects")]
    public GameObject pnjNameObject;
    public GameObject realDialogueObject;

    [Header("Text")]
    public TMPro.TextMeshPro pnjName;
    public TMPro.TextMeshProUGUI realDialogueText;

    [Header("Scripts")]
    public CastCheckPnj getRay;
    public TextDictionary textDictionary;
    public InteractWithPnj interactWithPnj;

    [Header("Other")]
    public string keyDialogues;
    public bool playerInBack;
    public bool playerNear;
    

    // Start is called before the first frame update
    void Start()
    {
        pnjName.SetText(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

        if (getRay.isPnj)
        {
            pnjNameObject.SetActive(true);
        }
        else
        {
            pnjNameObject.SetActive(false);
        }


        if (playerNear && !interactWithPnj.interactPressed)
        {
            if (playerInBack)
            {
                realDialogueObject.SetActive(true);
                realDialogueText.SetText(textDictionary.DialoguesDataBase[keyDialogues]);
            }
            else
            {
                realDialogueText.SetText(textDictionary.DialoguesDataBase["None"]);
                realDialogueObject.SetActive(false);
            }
        }
        else
        {
            realDialogueText.SetText(textDictionary.DialoguesDataBase["None"]);
            realDialogueObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }

}
