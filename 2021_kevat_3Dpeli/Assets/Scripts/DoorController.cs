using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, IInteractable
{

    public enum DoorState {Open, Close};
    public DoorState state = DoorState.Close;

    public float rotateSpeed = 1f;
    public float openAgle = 90;

    private Vector3 orginalRotation;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        orginalRotation = transform.eulerAngles;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            switch(state)
            {
                case DoorState.Close:

                    if(transform.eulerAngles != orginalRotation)
                    {
                        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, orginalRotation, rotateSpeed * Time.deltaTime);

                    }

                    else
                    {
                        isMoving = false;
                        state = DoorState.Close;

                    }

                break;

                case DoorState.Open:

                if(transform.eulerAngles.y != orginalRotation.y + openAgle)
                {
                    transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, orginalRotation + new Vector3(0, openAgle, 0), rotateSpeed * Time.deltaTime);

                }

                else
                    {
                        isMoving = false;
                        state = DoorState.Open;

                    }
                
                break;

            }

        }


    }

    public void Interact()
    {
        if(isMoving)
        {
            return;
        }

        if(state == DoorState.Close)
        {
            state = DoorState.Open;
        }

        else
        {
            state = DoorState.Close;
        }

        isMoving = true;


    }
}
