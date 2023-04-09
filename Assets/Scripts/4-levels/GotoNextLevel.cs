using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour {
    [SerializeField] string sceneName;
    [SerializeField] NumberField scoreField;
    [SerializeField] int minScoreToNextLevel = 50;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            if(scoreField.GetNumber() >= minScoreToNextLevel) {
                SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
            }
            else
            {
                other.transform.position = Vector3.zero;
                Debug.Log($"Missing points to next level: {minScoreToNextLevel-scoreField.GetNumber()} points left");
            }
        }
    }
}
