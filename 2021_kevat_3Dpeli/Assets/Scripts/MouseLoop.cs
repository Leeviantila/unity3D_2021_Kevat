using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLoop : MonoBehaviour
{

    public float mouseSnsitivity = 100f;
    public Transform playerBody;
    private float xRotation = 0f;






    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
