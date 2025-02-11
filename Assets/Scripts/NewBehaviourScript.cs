using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
     public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        RotateTowardsMouse();
    }

    public void Walk() {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    public void RotateTowardsMouse() {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousepos - rb.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        float rotationSpeed = 5.0f; 
        rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

}
