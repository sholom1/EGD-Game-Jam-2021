using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveForce;
    private new Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(MoveDelta * moveForce, ForceMode2D.Impulse);
    }
    private Vector2 MoveDelta;
    public void OnPlayerMove(CallbackContext ctx)
    {
        MoveDelta = ctx.ReadValue<Vector2>();
    }
}
