using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    [SerializeField]
    private Slider p1Slider, p2Slider;

    public static RoundManager instance;
    public UnityEvent OnRoundStart;
    private void Awake()
    {
        if (instance)
        {
            Debug.LogWarning($"Duplicate exists for singleton: {nameof(RoundManager)}");
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {
        OnRoundStart.AddListener(() =>
        {
            foreach (Health health in FindObjectsOfType<Health>())
            {
                health.OnDeath.AddListener(() => RoundOver(health.GetComponent<PlayerInput>().playerIndex));
            }
        });
    }
    public void RoundOver(int playerIndex)
    {
        throw new System.NotImplementedException();
    }
    public Slider GetSlider(int playerIndex) => playerIndex == 0 ? p1Slider : p2Slider;
}
