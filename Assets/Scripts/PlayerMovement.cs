using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;

    public GameManager gameManager;

    public GameObject objectiveUI;

    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorz, 0f, moveVert);
        rigb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Goal")
        {
            speed = 0f;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
