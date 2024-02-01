using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MoveSpeed1 : MonoBehaviour
{
    public Vector3 MoveVector = Vector3.zero;
    public float speed = 1.0f; 

    void Start()
    {
        // Initialization code can go here if needed
    }

    void Update()
    {
        bool LeftPress = Input.GetKey(KeyCode.A);
        bool RightPress = Input.GetKey(KeyCode.D);
        bool UpPress = Input.GetKey(KeyCode.W);
        bool DownPress = Input.GetKey(KeyCode.S);

        MoveVector = Vector3.zero;

        if (LeftPress)
        {
            MoveVector = new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (RightPress)
        {
            MoveVector = new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (UpPress)
        {
            MoveVector = new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (DownPress)
        {
            MoveVector = new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);
        }

        transform.position += MoveVector;
    }
}
