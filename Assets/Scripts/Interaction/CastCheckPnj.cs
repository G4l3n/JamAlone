using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastCheckPnj : MonoBehaviour
{


    [Header("Pnj Check")]
    public bool isPnj;
    public LayerMask whatIsPnj;
    public float distanceWithPnj;
    public Transform cam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isPnj = Physics.Raycast(cam.position, cam.forward, distanceWithPnj, whatIsPnj);
    }
}
