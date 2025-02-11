using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class PlayerInput : MonoBehaviour
{
    public float xAxis { get; set; }
    public float yAxis { get; set; }
    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");
    }

}
