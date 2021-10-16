using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class HitBox : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private new BoxCollider2D collider;
    private PlayerController player;
    public int playerIndex;
    public float DamagePotential;
    private void Start()
    {
        playerIndex = GetComponentInParent<PlayerInput>().playerIndex;
        player = GetComponentInParent<PlayerController>();
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.TryGetComponent<HitBox>(out HitBox otherHitBox) && otherHitBox.playerIndex != playerIndex)
        {
            float damage = otherHitBox.DamagePotential * DamagePotential * player.GetBaseDamage();
            //otherHitBox.GetComponentInParent<Health>().Damage(damage);
            //Do hit
            //Instantiate particles
        }
    }
}
