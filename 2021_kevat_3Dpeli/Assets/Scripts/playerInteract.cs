using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{
    public float range = 2f;
    Camera FPSCamera;



    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {

            ProcessRayCast();

        }

    }

    private void ProcessRayCast()
    {
        RaycastHit hit;

        if(Physics.Raycast(FPSCamera.transform.position, FPSCamera.transform.forward, out hit, range))
        {
            if(hit.collider.gameObject.GetComponent<IInteractable>() != null)
            {
                hit.collider.gameObject.GetComponent<IInteractable>();
                // hit.collider.gameObject.GetComponent<IInteractable>()?.Interact; -> null tarkistus. Vastaava kuin yllä


            }

        }


    }




}
