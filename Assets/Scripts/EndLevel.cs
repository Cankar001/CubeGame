using UnityEngine;

public class EndLevel : MonoBehaviour
    {
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
        {
        gameManager.levelComplete();
        }
}
