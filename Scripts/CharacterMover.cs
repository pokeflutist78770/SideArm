using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

    public float Speed;

    public float JumpForce;

    private bool canJump;

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            playerPosition.x = (transform.position.x + (Speed * Time.deltaTime));
            transform.position = playerPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            playerPosition.z = (transform.position.z + (Speed * Time.deltaTime));
            transform.position = playerPosition;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            playerPosition.z = (transform.position.z - (Speed * Time.deltaTime));
            transform.position = playerPosition;
        }

            if (Input.GetKey(KeyCode.A))
        {
            Vector3 playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            playerPosition.x = (transform.position.x - (Speed * Time.deltaTime));
            transform.position = playerPosition;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            canJump = false;
        }



    }
}

