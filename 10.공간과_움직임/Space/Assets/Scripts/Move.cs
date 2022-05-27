using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransfrom;

    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
        childTransfrom.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        childTransfrom.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 100) * Time.deltaTime);
            childTransfrom.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -100) * Time.deltaTime);
            childTransfrom.Rotate(new Vector3(0, -100, 0) * Time.deltaTime);
        }
    }
}
