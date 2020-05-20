using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _rotatorscript__ : MonoBehaviour
{
    [Range(-40, 40)]
    public float rotateSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * Time.deltaTime * rotateSpeed);
    }
}
