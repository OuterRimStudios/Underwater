using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = Camera.main.transform.TransformDirection(move);
        transform.position += move.normalized * speed * Time.deltaTime;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -57, 57), Mathf.Clamp(transform.position.y, 7, 42.5f), Mathf.Clamp(transform.position.z, -57, 57));
    }
}
