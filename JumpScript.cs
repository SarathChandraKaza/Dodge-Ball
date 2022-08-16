using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]
public class JumpScript : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce = 100.0f;

    private Rigidbody _body;
    public AudioSource source;
    public AudioClip jump;


    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnJump(InputAction.CallbackContext obj)
    {
        if (_body.position.y<10)
            {
            source.PlayOneShot(jump, 2);
            _body.AddForce(Vector3.up * jumpForce);
            }
        
    }
}
