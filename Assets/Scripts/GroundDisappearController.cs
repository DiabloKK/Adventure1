using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDisappearController : MonoBehaviour
{
    [SerializeField] private float timeDestroy = 0f;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            Destroy(gameObject, timeDestroy);
        }
    }
}
