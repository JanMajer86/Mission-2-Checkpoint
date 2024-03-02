using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float timePeriod;
    private float zAxisBound = 20f;
    private Vector3 startposition;

    void Start()
    {
        startposition = transform.position;
        zAxisBound /= 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startposition + new Vector3(0, 0, Mathf.Sin(Time.time) * zAxisBound);
    }


}
