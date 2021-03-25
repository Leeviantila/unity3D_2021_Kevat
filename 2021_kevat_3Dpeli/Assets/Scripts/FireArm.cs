﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArm : MonoBehaviour
{

    public string weponName = "";
    public float range = 10;
    public float attackPower = 1;
    public float fireRate = 0.05f;
    public float clipSize = 6;
    public bool automatic = false;

    Camera fpsCamera;



    // Start is called before the first frame update
    void Start()
    {
        fpsCamera = Camera.main;
        GetComponentInParent<Weapon>().setFireArm(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire() {
        print("Ampuu sarjaa");




    }




}