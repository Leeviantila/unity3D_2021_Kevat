using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public CharacterController controller;
    public float speed = 10f;
    public float gravity = -9.81f;
    private Vector3 velocity = Vector3.zero;
    public float jumpHeight = 3f;
    private bool isGrounded;




    // Start is called before the first frame update
    void Start()
    {
        // Toinen tapa yhdistää skripti componenttiin.
        //controller = GetComponent<CharacterController>();





    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        
        
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        
        
        if(Input.GetButtonDown("Jump") && isGrounded){
            Jump();

        }

        Move(x, z);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity* Time.deltaTime);

        

        
    }

    public void Move(float x, float z){
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

    }


    public void Jump(){
        
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        
        
    }



    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundDistance);



    }



}
 