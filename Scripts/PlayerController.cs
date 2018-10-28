using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Transform camTransform;

    public Vector3 MoveVector { set; get;}
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update(){
        MoveVector = PoolInput();

        MoveVector = RotateWithView();

        Move();

    }
    private void Move()
    {
        rb.AddForce((MoveVector * speed));
    }
    

    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        if (dir.magnitude > 1)
            dir.Normalize();
        return dir;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup")){
            other.gameObject.SetActive(false);
        }
    }
    private Vector3 RotateWithView()
    {
        if(camTransform != null)
        {
            Vector3 dir = camTransform.TransformDirection(MoveVector);
            dir.Set(dir.x, 0, dir.z);
            return dir.normalized *MoveVector.magnitude;
        }
        else
        {
            camTransform = Camera.main.transform;
            return MoveVector;
        }
    }
}