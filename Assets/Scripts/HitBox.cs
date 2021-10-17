using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CapsuleCollider2D))]
public class HitBox : MonoBehaviour
{
    private new CapsuleCollider2D collider;
    private PlayerController player;
    [SerializeField]
    private LayerMask hitLayer;
    [HideInInspector]
    public int playerIndex;
    public float DamagePotential;
    public float DamageResistance;
    private void Start()
    {
        playerIndex = GetComponentInParent<PlayerInput>().playerIndex;
        player = GetComponentInParent<PlayerController>();
        collider = GetComponent<CapsuleCollider2D>();
    }
    private void FixedUpdate()
    {
        if (player.isAttacking)
        {
            ContactFilter2D filter = new ContactFilter2D();
            filter.SetLayerMask(hitLayer);
            List<RaycastHit2D> hits = new List<RaycastHit2D>();
            if (collider.Cast(Vector2.left, filter, hits, collider.size.magnitude, true) > 0)
            {
                foreach (RaycastHit2D hit in hits)
                {
                    HitBox hitBox = hit.collider.GetComponent<HitBox>();
                    if (hitBox.playerIndex != playerIndex)
                    {
                        Debug.Log(hitBox.DamageResistance * DamagePotential * player.GetBaseDamage());
                        int damage = Mathf.CeilToInt(hitBox.DamageResistance * DamagePotential * player.GetBaseDamage());
                        hitBox.GetComponentInParent<Health>().Damage(damage);
                        player.CancelAttack();
                        break;
                    }
                }
            }
        }
    }
}
