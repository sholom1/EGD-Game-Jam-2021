using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
public class HitBox : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private new CapsuleCollider2D collider;
    private PlayerController player;
    [HideInInspector]
    public int playerIndex;
    public float DamagePotential;
    public float DamageResistance;
    private void Start()
    {
        playerIndex = GetComponentInParent<PlayerInput>().playerIndex;
        player = GetComponentInParent<PlayerController>();
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<CapsuleCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.TryGetComponent<HitBox>(out HitBox otherHitBox) && otherHitBox.playerIndex != playerIndex)
        {
            int damage = Mathf.CeilToInt(otherHitBox.DamagePotential * DamagePotential * player.GetBaseDamage());
            otherHitBox.GetComponentInParent<Health>().Damage(damage);
            //Do hit
            //Instantiate particles
        }
    }
}
