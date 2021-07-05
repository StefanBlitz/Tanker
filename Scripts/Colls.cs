using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colls : MonoBehaviour
{
    public AudioSource death;
    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "PEnemy"){
            Destroy(col.gameObject, 0);
            death.Play();
        }
    }
}
