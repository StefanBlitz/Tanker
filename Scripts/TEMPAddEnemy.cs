using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMPAddEnemy : MonoBehaviour
{
    public GameObject enemy;
    Vector2 ePos = new Vector2(10.0f, 7.0f);

    public void AddEnemy() {
        GameObject clone = Instantiate(enemy, ePos, transform.rotation);
        BoxCollider2D bc = clone.AddComponent<BoxCollider2D>() as BoxCollider2D;
    }
}
