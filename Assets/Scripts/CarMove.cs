using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speedCar = 10f;

    void Update()
    {
        transform.Translate(Vector3.forward * speedCar * Time.deltaTime);
    }
}
