using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class scCat : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Vector3 fvec;
    Animator animator;
    public int moveSpeed;
    private static readonly int moveSpeedHash = Animator.StringToHash("MoveSpeed");

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        var velocity = Vector3.forward  * Input.GetAxis("Vertical") * speed;
        transform.Translate(velocity * Time.deltaTime);
        transform.Rotate(Vector3.up, Time.deltaTime* Input.GetAxis("Horizontal")*rotationSpeed);
        animator.SetFloat("Speed", velocity.magnitude);
    }
}
