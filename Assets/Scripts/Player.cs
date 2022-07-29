using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private Rigidbody2D player;
    private bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void Jump()
    {
        player.velocity = new Vector2(player.velocity.x, jumpSpeed);
    }

    private void KillPlayer()
    {
        this.isRunning = false;
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.isRunning)
            {
                Jump();
            }
            else
            {
                this.isRunning = true;
            }
        }

        if (this.isRunning)
        {
            transform.position += transform.right * this.speed * Time.deltaTime;
        }
    }
}
