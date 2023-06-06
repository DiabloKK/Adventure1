using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAppearController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player") {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z);
        }
    }
}
