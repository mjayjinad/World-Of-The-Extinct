using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameobject : MonoBehaviour
{
    public float speed = 5.0f;
    private Quaternion initialRotation;
    // Start is called before the first frame update
    void Start()
    {
        initialRotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnEnable()
    {

        transform.rotation = initialRotation;
    }
}
