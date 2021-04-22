using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class journal : MonoBehaviour
{

    public static journal Instance;


    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            Instance = this;

        }



    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
