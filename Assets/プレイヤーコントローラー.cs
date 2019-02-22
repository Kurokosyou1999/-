using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class プレイヤーコントローラー : MonoBehaviour {

    public Rigidbody rigid;
    public Vector3 lastMousePosition;
    public Vector3 newAngle = new Vector3(0, 0, 0);


    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //rigidbody.AddForce(Vector3.forward * 30.0f, ForceMode.Impulse);
            rigid.AddRelativeForce(Vector3.forward * 20.0f, ForceMode.Impulse);
        }

        {
            if (Input.GetMouseButtonDown(1)) 
            {
                newAngle = transform.localEulerAngles;
                lastMousePosition = Input.mousePosition;
            
        } else if (Input.GetMouseButton(1))
        {

            newAngle.y -= (Input.mousePosition.x - lastMousePosition.x) * 0.1f;
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * 0.1f;

            if (newAngle.x <= -30.0f)
            {
                newAngle.x = -30.0f;
            }
            if (newAngle.x >= 30.0f)
            {
                newAngle.x = 30.0f;
            }
            gameObject.transform.localEulerAngles = newAngle;

            lastMousePosition = Input.mousePosition;
        }
    }

        }
        
        
    }


