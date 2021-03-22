using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
    {
    public Transform player;
    public Text scoreVal;

	// Update is called once per frame
	void Update ()
        {
        scoreVal.text = player.position.z.ToString("0");
	    }
    }
