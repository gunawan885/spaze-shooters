using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float lerpSpeed=1f;
    
    private void Start() {
    }
    
    public GameObject player;

    private void Update() {
        // transform.position = player.transform.position + new Vector3(0, 0, -10);
        transform.position = Vector3.Lerp(transform.position, player.transform.position + new Vector3(0, 0, -10), lerpSpeed);
        
    }
    
}
