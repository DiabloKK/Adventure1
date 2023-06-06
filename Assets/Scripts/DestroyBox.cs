using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject, 0.2f);
    }
}
