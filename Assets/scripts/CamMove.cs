using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float H = 2.0f;
    public float V = 2.0f;

    private float a = 0.0f;
    private float b = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a += H * Input.GetAxis("Mouse X");
        b -= V * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(a, b, 0.0f);
    }
}
