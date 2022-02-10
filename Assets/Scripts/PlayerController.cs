using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            Move(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            Move(Vector3.back);
        if (Input.GetKey(KeyCode.D))
            Move(Vector3.right);
        if (Input.GetKey(KeyCode.A))
            Move(Vector3.left);
    }

    void Move(Vector3 direction)
    {
        transform.position += direction *  speed * Time.deltaTime;
    }
}
