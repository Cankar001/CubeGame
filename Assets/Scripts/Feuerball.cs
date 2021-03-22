using UnityEngine;

public class Feuerball : MonoBehaviour
    {
    public GameObject spawnPosition;
    public GameObject spawnObject;
    public float spawnSpeed = 50f;
    public int spawnAmount = 30;

    int spawnedElements = 0;

    void Update()
        {
        // In jedem Frame schauen, ob ein neuer Feuerball erzeugt werden kann
        if (spawnedElements < spawnAmount)
            {
            Instantiate(spawnObject, spawnPosition.transform.position, spawnPosition.transform.rotation);
            spawnedElements++;
            }
        }
    }
