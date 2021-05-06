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
    public Transform weaponNode;

    public List<Transform> firearms = new List<Transform>();
    public int currentWeaponIndex = 0;




    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;

        foreach(Transform child in weaponNode)
        {
            if(child.GetComponent<FireArm>())
            {
                firearms.Add(child);

            }

        }




        UpdateCurrentWeapon();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){

            Heitto();
        }


        if (Input.GetButtonDown("Fire2")){

            Ammu();

        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            ChangeNextWeapon(1);

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

        public void ChangeNextWeapon(int nextIndex)
    {
        currentWeaponIndex += nextIndex;

        if(currentWeaponIndex > firearms.Count-1)
        {
            currentWeaponIndex = 0;

        }

            UpdateCurrentWeapon();

    }

    public void UpdateCurrentWeapon()
    {
        for(int i = 0; i < firearms.Count;i++)
        {
            if(currentWeaponIndex != i)
            {
                firearms[i].gameObject.SetActive(false);
            }

            else{

                firearms[i].gameObject.SetActive(true);
                fireArm = firearms[i].GetComponent<FireArm>();
                journal.Instance.Log(fireArm.weponName);

            }

        }

    }










}



