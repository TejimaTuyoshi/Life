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
            rbody.AddForce(Vector3.right * speedX, ForceMode.Force);
        }
        if (_isMove == false) 
        {
            speedX = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stop"))
        {
            _isMove = false;
            gameObject.transform.position = new Vector3(2470,1,-1);
        }
    }
}
