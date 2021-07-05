using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static Movement instance;

    void Awake(){

     instance = this;

 }
    public GameObject player;
    Rigidbody2D rb;
    public bool moveUp, moveDown, moveLeft, moveRight = false;
    Vector3 rotation;
    float x = 0.0f;
    float y = 0.0f;
    public float z = 0.0f;

    public void Start() {
       rb = GetComponent<Rigidbody2D>();
    }

    public void MoveUpTrue() { 

        moveUp = true;
        z = 0.0f;
        rotation = new Vector3(x, y, z);
    }

    public void MoveUpFalse() { moveUp = false; }
    public void MoveLeftTrue() { 
        moveLeft = true;
        z = 90.0f;
        rotation = new Vector3(x, y, z);
    }

    public void MoveLeftFalse() { moveLeft = false; }
    public void MoveDownTrue() { 
        moveDown = true;
        z = 180.0f;
        rotation = new Vector3(x, y, z);
    }

    public void MoveDownFalse() { moveDown = false; }
    public void MoveRightTrue() { 
        moveRight = true;
        z = -90.0f;
        rotation = new Vector3(x, y, z);
    }
    public void MoveRightFalse() { moveRight = false; }

    public void Update() {
        switch (moveUp) {
            case true:
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.5f);
                player.transform.eulerAngles = rotation;
                break;
        }
        switch(moveLeft) {
            case true:
                 player.transform.position = new Vector2(player.transform.position.x - 0.5f, player.transform.position.y);
                 player.transform.eulerAngles = rotation;
                 break;
        }
        switch (moveDown) {
            case true:
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 0.5f);
                player.transform.eulerAngles = rotation;
                break;
        }
        switch(moveRight) {
            case true:
                 player.transform.position = new Vector2(player.transform.position.x + 0.5f, player.transform.position.y);
                 player.transform.eulerAngles = rotation;
                 break;
        }
    }

    
}
