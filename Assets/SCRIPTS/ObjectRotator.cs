using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{

    public Transform ObjectTransform;

    public Vector3 AngularSpeedMultipliers = new Vector3(0,1,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ObjectTransform.Rotate(AngularSpeedMultipliers * Time.deltaTime);

    }
}
