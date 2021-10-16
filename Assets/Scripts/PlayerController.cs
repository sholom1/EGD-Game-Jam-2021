using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveForce;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private LayerMask GroudMask;
    [SerializeField]
    private List<Ability> abilities;
    private Dictionary<string, Ability> abilityLookup;
    [HideInInspector]
    private Ability activeAbility;

    private Animator anim;
    private new Rigidbody2D rigidbody;
    private PlayerInput input;
    private float horizontalMove;
    private bool isJumping = false;
    private float cooldown;
    // Start is called before the first frame update
    void Start()
    { 
        rigidbody = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInput>();
        anim = GetComponent<Animator>();
        abilityLookup = new Dictionary<string, Ability>();
        abilities.ForEach(ability => abilityLookup.Add(ability.name, ability));
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(new Vector2(horizontalMove * moveForce, isGrounded && isJumping ? jumpForce : 0), ForceMode2D.Impulse);
        if (isJumping) isJumping = !isJumping;
    }
    public void OnMovementHorizontal(InputValue value)
    {
        horizontalMove = value.Get<float>();
    }
    public void OnJump(InputValue value)
    {
        isJumping = value.isPressed;
    }
    private void triggerAbility(string name)
    {
        if (cooldown < 0 && abilityLookup.TryGetValue(name, out Ability ability))
        {
            activeAbility = ability;
            anim.SetTrigger(activeAbility.triggerName);
            cooldown = activeAbility.Cooldown;
        }
    }
    public void OnPowerAttack() => triggerAbility("PowerAttack");
    private bool isGrounded => Physics2D.Raycast(transform.position, Vector2.down, float.MaxValue, GroudMask).distance < 1f;

    public float GetBaseDamage() => activeAbility.getBaseDamage(cooldown);
}
