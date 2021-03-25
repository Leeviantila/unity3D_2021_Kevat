using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float heittoVoima = 10f;
    public GameObject heittoObjektiPrefab;
    private Camera FPSCamera;

    public Transform heittoPiste;
    public FireArm fireArm;



    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")){

            Heitto();
        }


        if (Input.GetButtonDown("Fire1")){

            Ammu();



        }




    }
        


        

    private void Heitto()
    {
        GameObject obj = Instantiate(heittoObjektiPrefab, heittoPiste.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(FPSCamera.transform.forward * heittoVoima);


    }

    public void Ammu()
    {

        if (fireArm != null){

            fireArm.Fire();

        }

        else
        {
            print("Asetta ei ole asetettu");


        }


    }

    public void setFireArm(FireArm newfirearm)
    {
        fireArm = newfirearm;



    }

}



