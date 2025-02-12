using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput playerInput;
    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        playerInput = GetComponent<PlayerInput>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerInput.XAxis, playerInput.YAxis).normalized * Speed * Time.fixedDeltaTime;
    }
}
