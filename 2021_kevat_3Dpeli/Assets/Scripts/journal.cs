using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class journal : MonoBehaviour
{

    public static journal Instance;
    public TMP_Text textBox;
    public GameObject textBoxImage;
    public float textFadeOutDuration = 1f;
    private float countDown;


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

        DisableTextBox();

    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textBoxImage.activeSelf)
        {
            countDown -= Time.deltaTime;

            if(countDown <= 0)
            {
                DisableTextBox();


            }
        }

        
    }


    public void Log(string text) {
            textBoxImage.SetActive(true);
            textBox.text = text;
            countDown = textFadeOutDuration;


    }

    private void DisableTextBox() {
        
        textBox.text = "";
        textBoxImage.SetActive(false);


    }



}
