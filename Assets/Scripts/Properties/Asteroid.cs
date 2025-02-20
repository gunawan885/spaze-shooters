using System;
using UnityEngine;

public class Asteroid : MonoBehaviour, IProperty
{
    [SerializeField]
    private float health = 0;
    public float Health{get=>health;set=>health= Mathf.Max(value, 0); }

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("nyawa Asteroid: "+Health);
    }

}