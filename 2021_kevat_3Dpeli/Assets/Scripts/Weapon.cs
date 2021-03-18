using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float heittoVoima = 10f;
    public GameObject heittoObjektiPrefab;
    private Camera FPSCamera;



    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){

            Heitto();
        }

    }

    private void Heitto()
    {
        GameObject obj = Instantiate(heittoObjektiPrefab, transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(FPSCamera.transform.forward * heittoVoima);


    }


}
