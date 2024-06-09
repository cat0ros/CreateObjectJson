using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private float massPlayer = 10f;

    private const float minMass = 10f;
    private const float maxMass = 60f;

    public float MassPlayer
    {
        get => massPlayer;
        set => massPlayer = Mathf.Clamp(value, minMass, maxMass);
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
