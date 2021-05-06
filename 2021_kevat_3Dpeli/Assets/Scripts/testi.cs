﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testi : MonoBehaviour, ITakeDamage<float>, IDie, IInteractable
{

    public string objName = "enemy";
    public float health = 5;
    bool isAlive = true;
    public void Damage(float Damage)
    {
        if(!isAlive){

            return;
        }

        health = Mathf.Max(health-Damage, 0);

        if(health <= 0){

            Die();
        }


        print($"minuun osui:{Damage}");

    }

    public void Die()
    {
        // lisää kuolemis efektit
        Destroyobj();

    }

    public void Destroyobj(){

        Destroy(gameObject);

    }



    public void Interact()
    {
        journal.Instance.Log($"Object name is {objName} and it has {health} hp.");


    }

    public void TakeDamage(){
        print("minuun osui");
    }


}
