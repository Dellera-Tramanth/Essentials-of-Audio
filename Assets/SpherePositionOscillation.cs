using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePositionOscillation : MonoBehaviour
{
    public float movementFrequency = 0.5f;
    public float movementAmplitude = 5.0f;
    public Vector3 movementVector;
    public Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.localPosition;
    }
    
    // Update is called once per frame
    void Update()
    {
        movementVector.x = movementAmplitude * Mathf.Sin(2*Mathf.PI*movementFrequency*Time.time);
        transform.localPosition = startingPosition + movementVector;  
    }
}
