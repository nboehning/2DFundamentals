using UnityEngine;
using System.Collections;

public class triggers : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Coin Collected");
        Destroy(gameObject);
    }
}
