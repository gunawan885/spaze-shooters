using UnityEngine;

public class Rotate: MonoBehaviour{
    public Vector2 RelativeDirection { get; set; }
    void Update()
    {
        RotateTowardsMouse();
    }
    public void RotateTowardsMouse() {
        // kode ini untuk mengarahkan player ke arah sesuai  mouse
        // Mengambil posisi mouse di layar dan mengonversinya ke koordinat
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Menghitung vektor arah dari posisi objek
        RelativeDirection = mousepos - (Vector2)transform.position;
        // Menghitung sudut rotasi yang diperlukan agar objek menghadap ke arah mouse.
        float angle = Mathf.Atan2(RelativeDirection.y, RelativeDirection.x) * Mathf.Rad2Deg - 90f;
        // Membuat rotasi berdasarkan sudut yang dihitung.
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // Mengontrol kecepatan rotasi objek.
        float rotationSpeed = 5.0f; 
        // Menginterpolasi rotasi saat ini ke rotasi target secara halus.
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}