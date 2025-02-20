using UnityEngine;

public class BulletEffector: MonoBehaviour
{
    public float damage= 0;
    private void ImposeDamage(Transform transform)
    {
        transform.GetComponent<IProperty>().Health -= damage;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        ImposeDamage(collision.transform);
        Destroy(gameObject);
    }
}