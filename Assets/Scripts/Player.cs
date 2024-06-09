using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    private Rigidbody rb;

    private const float forceJump = 70f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (playerData == null)
        {
            throw new NullReferenceException(nameof(playerData) + " cannot be null.");
        }
    }

    public void Jump()
    {
        if (playerData != null)
        {
            rb.mass = playerData.MassPlayer;
            rb.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
        }
    }
}
