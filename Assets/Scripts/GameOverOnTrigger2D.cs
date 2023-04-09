using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] int numberOfLives = 3;

    private int livesLeft;
    
    void Awake()
    {
        livesLeft = numberOfLives;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
            if (--livesLeft <= 0)
            {
                Debug.Log("Game over!");
                Application.Quit();
                // UnityEditor.EditorApplication.isPlaying = false; 
                return;
            }
            
            Debug.Log($"You got {livesLeft} lifes left");
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
