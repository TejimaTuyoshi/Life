using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rbody;
    [SerializeField] float speedZ;
    [SerializeField] float speedX = 0.05f;
    public bool _isMove = true;    
    void Start()
    {
        rbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_isMove == true)
        {
            rbody.AddForce(Vector3.right * speedX, ForceMode.VelocityChange);
        }
        else if (_isMove == false) 
        {
            speedX = 0;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rbody.AddForce(Vector3.forward * speedZ, ForceMode.Force);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rbody.AddForce(Vector3.back * speedZ, ForceMode.Force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stop"))
        {
            _isMove = false;
            gameObject.transform.position = new Vector3(2450,1,-1);
        }
    }
}
