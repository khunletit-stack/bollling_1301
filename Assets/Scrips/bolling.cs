using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class bolling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            Shootball();

        if(Keyboard.current.rightArrowKey.isPressed)
            MoveRight();

        if (Keyboard.current.leftArrowKey.isPressed)
            MoveLeft();
    }
    private void Shootball()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);
    }

    private void MoveRight()
    {
        transform.position += new Vector3(0.5f, 0f, 0f) * Time.deltaTime;
    }

    private void MoveLeft()
    {
        transform.position += new Vector3(-0.5f, 0f, 0f) * Time.deltaTime;
    }
}



