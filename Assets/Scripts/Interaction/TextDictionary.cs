using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDictionary : MonoBehaviour
{

    public Dictionary<string, string> DialoguesDataBase = new Dictionary<string, string>()
    {
        {"None", ""},
        {"Test", "blablabla oulala" },
        {"Two", "j'ai reussi"},
        {"dos", "tu es dans mon dos"},
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
