using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public AudioSource shoot;
    public Rigidbody2D rb;
    public GameObject bC;
    
    Vector3 rotation;
    Vector3 playerPos;
    float pX, pY;
    float vX = 0.0f;
    float vY = 0.0f;

    public void ShootOncePressed() {
        Rigidbody2D clone = Instantiate(rb, playerPos, transform.rotation);
        clone.velocity = new Vector2(vX, vY);
        shoot.Play();
    }
    void Update() {
        bC = GameObject.Find("Bullet(Clone)");
        Destroy(bC, 0.2f);
        playerPos = new Vector2(pX, pY);

        switch(Movement.instance.z) {
            case 180.0f:
                vY = -75.0f;
                pY = Movement.instance.player.transform.position.y - 3.0f;
                pX = Movement.instance.player.transform.position.x;
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                break;
            case 0.0f:
                vY = 75.0f;
                pY = Movement.instance.player.transform.position.y + 3.0f;
                pX = Movement.instance.player.transform.position.x;
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                break;
            case 90.0f:
                vX = -75.0f;
                pY = Movement.instance.player.transform.position.y;
                pX = Movement.instance.player.transform.position.x - 3.0f;
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;
                break;
            case -90.0f:
                vX = 75.0f;
                pY = Movement.instance.player.transform.position.y;
                pX = Movement.instance.player.transform.position.x + 3.0f;
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;
                break;    
        }
    }
}
