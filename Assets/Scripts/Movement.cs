using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float goForwardVelocity;
    [SerializeField]
    private float LeftAndRightVelocity;
    void Start()
    {
        
    }

    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * LeftAndRightVelocity * Time.deltaTime;
        this.transform.Translate(yatayEksen, 0, goForwardVelocity * Time.deltaTime);
        this.transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -4.5f, 4.5f));
    }
}
