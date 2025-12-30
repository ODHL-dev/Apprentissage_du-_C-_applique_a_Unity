using System;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My firt programme");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=Vector3.up *speed*Time.deltaTime ;
    }
}
