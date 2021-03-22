using UnityEngine;

public class PlayerMovement : MonoBehaviour
    {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float moveSpeed = 30f;
	
	void FixedUpdate ()
        {
        // Konstante Vorwärtsbewegung, (Friction auf 0 in Unity setzen, um bewegung ohne rotation zu bekommen)
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (rb.position.y < -1f)
            {
            FindObjectOfType<GameManager>().GameOver();
            }
        if (Input.GetKey("d"))
            {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        if (Input.GetKey("a"))
            {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
