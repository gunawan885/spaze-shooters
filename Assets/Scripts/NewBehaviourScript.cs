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
        // kode ini  untuk jalan player
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    public void RotateTowardsMouse() {
        // kode ini untuk mengarahkan player ke arah sesuai  mouse
        // Mengambil posisi mouse di layar dan mengonversinya ke koordinat
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Menghitung vektor arah dari posisi objek
        Vector2 direction = mousepos - rb.position;
        // Menghitung sudut rotasi yang diperlukan agar objek menghadap ke arah mouse.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        // Membuat rotasi berdasarkan sudut yang dihitung.
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // Mengontrol kecepatan rotasi objek.
        float rotationSpeed = 5.0f; 
        // Menginterpolasi rotasi saat ini ke rotasi target secara halus.
        rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

}
