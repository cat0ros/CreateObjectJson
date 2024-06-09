using TMPro;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private float massPlayer = 10f;

    public float MassPlayer
    {
        get => massPlayer;
        set => massPlayer = Mathf.Clamp(value, 10f, 60f);
    }

    public void AddMass(float massStep)
    {
        MassPlayer += massStep;
    }

    public void MinusMass(float massStep)
    {
        MassPlayer -= massStep;
    }
}
