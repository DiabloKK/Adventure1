using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;

    private ItemColector itemColector;

    private void Start() {
        finishSound = GetComponent<AudioSource>();
        itemColector = FindObjectOfType<ItemColector>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player" && !levelCompleted && itemColector.isFullCherries()) {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
