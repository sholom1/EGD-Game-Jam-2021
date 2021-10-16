using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    public new string name;
    public float Cooldown;
    public string triggerName;
    [SerializeField]
    private AnimationCurve progressModifier;
    [SerializeField]
    private float baseDamage;

    public float getBaseDamage(float time)
    {
        time = Mathf.Max(time, 0);
        return baseDamage * progressModifier.Evaluate(time / Cooldown);
    }
}
