using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    [SerializeField]
    private HatVisualiser hatVisualiser;

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

    public void Update(){
        transform.localScale = new Vector3(playerData.WidthPlayer, playerData.HeightPlayer, transform.localScale.z);
    }
}
